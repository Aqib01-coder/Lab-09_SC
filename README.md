☕ Coffee Shop Ordering System

A simple C# console application that demonstrates OOP concepts such as classes, objects, encapsulation, and composition.
The program simulates a coffee shop workflow where customers place orders, totals are calculated, and payments are processed.

📌 Features

Menu system with updateable prices

Customer order handling for coffee and sandwiches

Automatic total calculation

Payment processing simulation

Demonstrates OOP principles

🧱 Project Structure
Menu.cs            → Stores item prices and allows updates
Order.cs           → Stores customer orders and calculates totals
PaymentProcessor.cs → Handles payment processing
CoffeeShop.cs      → Main shop logic (processing orders, updating menu)
Program.cs         → Entry point of the application

🧪 Example Output
Order processed for Aqib
Total amount to pay: 5
Processing payment of 5

Order processed for Awais
Total amount to pay: 13
Processing payment of 13

Order processed for Suleman
Total amount to pay: 9
Processing payment of 9

🚀 How It Works

A Menu object is created with initial prices.

A CoffeeShop is created using that menu.

Orders are created for customers and processed.

Menu prices can be updated dynamically.

Payment is simulated by printing to console.

🛠️ Code Example

Here is how the program processes an order:

Order order1 = new Order("Aqib", true, false);
shop.ProcessOrder(order1);

🧩 OOP Concepts Used

Encapsulation

Composition (CoffeeShop HAS a Menu and PaymentProcessor)

Classes & Objects

Methods with responsibilities

▶️ How to Run

Clone the repository:

git clone https://github.com/your-username/your-repo-name


Open the folder in Visual Studio or VS Code.

Build and run the project.

📄 License

This project is open-source and free to use.
