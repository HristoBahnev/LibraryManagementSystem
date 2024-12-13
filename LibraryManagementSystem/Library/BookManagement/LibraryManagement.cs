using LibraryManagement.Members;

namespace LibraryManagement.BookManagement
{
    public abstract class LibraryManagement
    {
        public abstract void AddBook(Book book);
        public abstract void RemoveBook(string isbn);
        public abstract void BorrowBook(string isbn, Member member);
        public abstract void ReturnBook(string isbn, Member member);
    }
}