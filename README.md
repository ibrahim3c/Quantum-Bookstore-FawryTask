# Quantum Bookstore 

Welcome to **Quantum Bookstore**, a console-based book inventory system built as part of the Fawry N² Dev Slope #10 Challenge.

This application demonstrates key OOP principles, extensibility, and clean architecture using C# and .NET.

---

## Features

- Add books of different types:
  - Paper Book (with quantity & shipping)
  - EBook (with file type & email delivery)
  - Demo Book (read-only preview, not for sale)
- Remove outdated books (older than a given number of years)
- Buy books using ISBN
  - Ships paper books via ShippingService
  - Sends ebooks via EmailService
  - Rejects demo book purchases
- Clean, extensible architecture
- Console-based output logging with clear format

---

## 📸 Screenshot

Below is a sample screenshot from the running app:

![Quantum Bookstore Screenshot](images/console-output.png)

> Place your actual console screenshot in the `images` folder and name it `console-output.png` (or update the filename if different).

---

## 🚀 How to Run

1. Clone the repository or copy the source code.
2. Open the solution in Visual Studio or VS Code.
3. Set `QuantumBookstoreFullTest.RunAll()` or `Main()` as the startup point.
4. Run the application.

You will see output in the console showing all operations step by step.

---

##  Architecture Notes

- `Book` is an abstract base class.
- Each book type (`PaperBook`, `EBook`, `DemoBook`) overrides behavior like `BuyBook()` and `Display()`.
- Services like `ShippingService` and `EmailService` are injected and abstracted.
- All console logs are prefixed with `Quantum book store:` as required.
