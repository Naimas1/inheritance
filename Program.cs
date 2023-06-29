using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program;
class Money
{
    private int dollars;
    private int cents;


    public Money(int dollars, int cents)

    {
        this.dollars = dollars;
        this.cents = cents;
    }

    public int Cents { get; internal set; }
    public object Dollars { get; internal set; }

    public void DisplayAmount()
    {
        Console.WriteLine($"Amount: {dollars}.{cents:00}");
    }

    public void SetAmount(int dollars, int cents)
    {
        this.dollars = dollars;
        this.cents = cents;
    }
}

class Product
{
    private string name;
    private Money price;

    public Product(string name, Money price)
    {
        this.name = name;
        this.price = price;
    }

    public void DisplayPrice()
    {
        Console.WriteLine($"Price of {name}: ");
        price.DisplayAmount();
    }

    public void DecreasePrice(int dollars, int cents)
    {
        int totalCents = priceCents(price) - dollars * 100 - cents;
        if (totalCents < 0)
        {
            Console.WriteLine("New price cannot be negative.");
            return;
        }

        int newDollars = totalCents / 100;
        int newCents = totalCents % 100;
        price.SetAmount(newDollars, newCents);
    }

    private int priceCents(Money money)
    {
        return moneyCents(money) + dollarsToCents(money.Dollars);
    }

    private int dollarsToCents(object dollars)
    {
        throw new NotImplementedException();
    }

    private int moneyCents(Money money)
    {
        return money.Cents;
    }

    private int dollarsToCents(int dollars)
    {
        return dollars * 100;
    }
}

internal class Proga
{
    static void Main(string[] args)
    {
        Money money = new Money(10, 50);
        money.DisplayAmount();

        Product product = new Product("Example Product", money);
        product.DisplayPrice();

        product.DecreasePrice(2, 30);
        product.DisplayPrice();
    }
}