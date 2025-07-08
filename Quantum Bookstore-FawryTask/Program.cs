
using Quantum_Bookstore_FawryTask;

var inventory = new Inventory();
var quantumBookstoreTest = new QuantumBookstoreTest(inventory);



quantumBookstoreTest.AddBooksToInventory();
quantumBookstoreTest.DisplayAllBooks();
Console.WriteLine();

quantumBookstoreTest.RemoveOutdatedBooks();
quantumBookstoreTest.DisplayAllBooks();
Console.WriteLine();

quantumBookstoreTest.BuyPaperBook();

quantumBookstoreTest.BuyEBook();

quantumBookstoreTest.BuyDemoBook();


