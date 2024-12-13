namespace LibraryManagement.BookManagement
{
    public class Book
    {
        private string _title;
        private string _author;
        private string _isbn;
        private int _availableCopies;

        public Book(string title, string author, string isbn, int copies)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
            AvailableCopies = copies;
        }

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public string Author
        {
            get { return _author; }
            set { _author = value; }
        }

        public string ISBN
        {
            get { return _isbn; }
            set { _isbn = value; }
        }

        public int AvailableCopies
        {
            get { return _availableCopies; }
            set { _availableCopies = value; }
        }

        public bool Borrow()
        {
            if (AvailableCopies > 0)
            {
                AvailableCopies--;
                return true;
            }
            return false;
        }

        public void Return()
        {
            AvailableCopies++;
        }
    }
}