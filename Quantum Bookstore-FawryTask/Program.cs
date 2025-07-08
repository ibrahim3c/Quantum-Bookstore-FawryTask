
using Quantum_Bookstore_FawryTask;

var inventory = new Inventory();
var quantumBookstoreTest = new QuantumBookstoreTest(inventory);


quantumBookstoreTest.AddBooksToInventory();

quantumBookstoreTest.RemoveOutdatedBooks();

quantumBookstoreTest.BuyPaperBook();

quantumBookstoreTest.BuyEBook();

quantumBookstoreTest.BuyDemoBook();

