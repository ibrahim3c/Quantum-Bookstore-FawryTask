namespace Quantum_Bookstore_FawryTask
{
    internal class Inventory
    {
        private List<Book> books;
        public Inventory()
        {
            books = new List<Book>();
        }
        public void AddBook(Book book)
        {
            books.Add(book);
        }
        public void RemoveOutdatedBooks(int years)
        {
            books.RemoveAll(book => book.IsOutdated(years));
        }

        public decimal BuyBook(string isbn,IBuyingInfo info)
        {
                var book = books.FirstOrDefault(b => b.ISBN == isbn);
                if (book == null)
                    throw new Exception("This book is not found.");

                return book.BuyBook(info);
        }
    }
}
