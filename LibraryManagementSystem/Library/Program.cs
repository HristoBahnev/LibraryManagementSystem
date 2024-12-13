using LibraryManagement.Members;
using LibraryManagement.BookManagement;

namespace LibraryManagement
{
    public class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            library.AddBook(new Book("The little prince", "Antoine de Saint-Exupery", "11111", 1));
            library.AddBook(new Book("Fifty shades of grey", "E. L. James", "333333", 2));

            Member student = new StudentMember("Ivancho", "008", "Student", 10);
            Member staff = new StaffMember("Mariika", "007", "Staff", 5);

            library.BorrowBook("11111", student);
            library.BorrowBook("333333", student);
            library.BorrowBook("11111", staff);
            library.BorrowBook("333333", staff);

            library.ReturnBook("11111", student);
            library.BorrowBook("11111", staff);
        }
    }
}
