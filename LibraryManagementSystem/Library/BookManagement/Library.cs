using LibraryManagement.Members;
namespace LibraryManagement.BookManagement
{
    public class Library : LibraryManagement
    {
        private List<Book> _books = new List<Book>();

        public override void AddBook(Book book)
        {
            _books.Add(book);
            Console.WriteLine($"Added book:{book.Title} by {book.Author}.");
        }

        public override void RemoveBook(string isbn)
        {
            foreach (var book in _books)
            {
                if (book.ISBN == isbn)
                {
                    _books.Remove(book);
                    Console.WriteLine($"Removed book: {book.Title} by {book.Author}.");
                    return;
                }
            }
            Console.WriteLine("Book not found.");
        }

        public override void BorrowBook(string isbn, Member member)
        {
            foreach (var book in _books)
            {
                if (book.ISBN == isbn)
                {
                    member.BorrowBook(book);
                    return;
                }
            }
            Console.WriteLine("Book not found.");
        }

        public override void ReturnBook(string isbn, Member member)
        {
            foreach (var book in _books)
            {
                if (book.ISBN == isbn)
                {
                    member.ReturnBook(book);
                    return;
                }
            }
            Console.WriteLine("Book not found.");
        }
    }
}
