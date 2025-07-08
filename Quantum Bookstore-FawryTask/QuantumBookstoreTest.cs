namespace Quantum_Bookstore_FawryTask
{
    internal class QuantumBookstoreTest
    {
        private Inventory inventory { get; }

        public QuantumBookstoreTest(Inventory inventory)
        {
            this.inventory = inventory;
        }
        public  void AddBooksToInventory()
        {
            Console.WriteLine("Adding books...");

            var paperBook = new PaperBook("B1", "Book1", new DateTime(2024, 1, 1), 300m, 10);
            var eBook = new EBook("B2", "Book2", new DateTime(2020, 6, 1), 200m, "PDF");
            var demoBook = new DemoBook("B3", "Book3", new DateTime(2021, 5, 1), 0);
            var outdatedBook = new DemoBook("B4", "Book3", new DateTime(2010, 5, 1), 0);

            inventory.AddBook(paperBook);
            inventory.AddBook(eBook);
            inventory.AddBook(demoBook);
            inventory.AddBook(outdatedBook);

            Console.WriteLine("Books added successfully.\n");
        }

        public  void RemoveOutdatedBooks()
        {
            Console.WriteLine("Removing outdated books (older than 10 years)...");
            inventory.RemoveOutdatedBooks(10);
        }

        public  void BuyPaperBook()
        {
            try
            {
                Console.WriteLine("Buying paper book...");
                var info = new BuyingPaperBookInfo
                {
                    Quantity = 2,
                    Address = "123 Book Street"
                };

                var amountPaid = inventory.BuyBook("B1", info);

                Console.WriteLine($"Paper book purchased. Total paid: {amountPaid}\n");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public  void BuyEBook()
        {
            Console.WriteLine("Buying eBook...");
            var info = new BuyingEBookInfo
            {
                Email = "user@example.com"
            };

            var amountPaid = inventory.BuyBook("B2", info);

            Console.WriteLine($"eBook purchased. Total paid: {amountPaid}\n");
        }

        public  void BuyDemoBook()
        {
            Console.WriteLine("Buying demo book...");
            try
            {
                var info = new BuyingDemoBookInfo
                {
                };
                inventory.BuyBook("B3",info);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        internal void DisplayAllBooks()
        {
            inventory.DisplayAllBooks();
        }
    }
}
