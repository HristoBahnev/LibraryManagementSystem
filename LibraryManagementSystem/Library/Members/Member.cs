using LibraryManagement.BookManagement;

namespace LibraryManagement.Members
{
    public abstract class Member
    {
        private string _name;
        private string _memberID;
        private string _membershipType;
        private int _borrowingLimit;
        private List<Book> _borrowedBooks = new List<Book>();

        public Member(string name, string memberID, string membershipType, int borrowingLimit)
        {
            Name = name;
            MemberID = memberID;
            _membershipType = membershipType;
            _borrowingLimit = borrowingLimit;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string MemberID
        {
            get { return _memberID; }
            set { _memberID = value; }
        }

        public string MembershipType
        {
            get { return _membershipType; }
            set { _membershipType = value; }
        }

        public int BorrowingLimit
        {
            get { return _borrowingLimit; }
            set { _borrowingLimit = value; }
        }

        public List<Book> BorrowedBooks
        {
            get { return _borrowedBooks; }
        }

        public bool BorrowBook(Book book)
        {
            if (BorrowedBooks.Count >= BorrowingLimit)
            {
                Console.WriteLine($"{Name} ({MembershipType}) cannot borrow more books. Limit reached.");
                return false;
            }

            if (!book.Borrow())
            {
                Console.WriteLine($"{Name} ({MembershipType}) cannot borrow \"{book.Title}\". No copies available.");
                return false;
            }

            BorrowedBooks.Add(book);
            Console.WriteLine($"{Name} ({MembershipType}) borrowed \"{book.Title}\". Books borrowed: {BorrowedBooks.Count}/{BorrowingLimit}.");
            return true;
        }

        public void ReturnBook(Book book)
        {
            if (BorrowedBooks.Remove(book))
            {
                book.Return();
                Console.WriteLine($"{Name} ({MembershipType}) returned \"{book.Title}\". Copies available: {book.AvailableCopies}.");
            }
            else
            {
                Console.WriteLine($"{Name} ({MembershipType}) did not borrow \"{book.Title}\".");
            }
        }
    }
}