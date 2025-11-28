using System;

public class Menu
{
    public double CoffeePrice { get; private set; }
    public double SandwichPrice { get; private set; }

    public Menu(double coffeePrice, double sandwichPrice)
    {
        CoffeePrice = coffeePrice;
        SandwichPrice = sandwichPrice;
    }

    public void UpdatePrices(double coffeePrice, double sandwichPrice)
    {
        CoffeePrice = coffeePrice;
        SandwichPrice = sandwichPrice;
    }
}

public class Order
{
    public string CustomerName { get; }
    public bool WantsCoffee { get; }
    public bool WantsSandwich { get; }

    public Order(string customerName, bool wantsCoffee, bool wantsSandwich)
    {
        CustomerName = customerName;
        WantsCoffee = wantsCoffee;
        WantsSandwich = wantsSandwich;
    }

    public double CalculateTotal(Menu menu)
    {
        double total = 0;

        if (WantsCoffee)
            total += menu.CoffeePrice;

        if (WantsSandwich)
            total += menu.SandwichPrice;

        return total;
    }
}

public class PaymentProcessor
{
    public void Process(double amount)
    {
        Console.WriteLine($"Processing payment of {amount}");
    }
}

public class CoffeeShop
{
    private readonly Menu _menu;
    private readonly PaymentProcessor _paymentProcessor;

    public CoffeeShop(Menu menu)
    {
        _menu = menu;
        _paymentProcessor = new PaymentProcessor();
    }

    public void ProcessOrder(Order order)
    {
        double total = order.CalculateTotal(_menu);

        Console.WriteLine($"Order processed for {order.CustomerName}");
        Console.WriteLine($"Total amount to pay: {total}");

        _paymentProcessor.Process(total);
    }

    public void UpdateMenu(double coffeePrice, double sandwichPrice)
    {
        _menu.UpdatePrices(coffeePrice, sandwichPrice);
    }
}

public class Program
{
    public static void Main()
    {
        Menu menu = new Menu(5.0, 8.0);
        CoffeeShop shop = new CoffeeShop(menu);

        Order order1 = new Order("Aqib", true, false);
        shop.ProcessOrder(order1);

        Order order2 = new Order("Awais", true, true);
        shop.ProcessOrder(order2);

        shop.UpdateMenu(6.0, 9.0);

        Order order3 = new Order("Suleman", false, true);
        shop.ProcessOrder(order3);
    }
}