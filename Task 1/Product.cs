namespace Task_1;

public class Product
{
    private string name;
    private Money price;
    
    public Product() {}

    public Product(string name, Money price)
    {
        this.name = name;
        this.price = price;
    }

    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            name = value;
        }
    }

    public Money Price
    {
        get
        {
            return price;
        }
        set
        {
            price = value;
        }
    }
    
    public void TakePriceLess(double priceReduction)
    {
        int previousPriceInPennies = price.Units * 100 + price.Pennies;
        int priceReductionInPennies = (int)Math.Round(priceReduction * 100);

        if (previousPriceInPennies < priceReductionInPennies)
        {
            throw new ArgumentOutOfRangeException(nameof(priceReduction), "Price reduction are bigger than current price");
        }
        
        int newPriceInPennies = previousPriceInPennies - priceReductionInPennies;

        price.Units = newPriceInPennies / 100;
        price.Pennies = newPriceInPennies % 100;
    }

    public override string ToString()
    {
        return $"Name: {name}\nPrice: {price}";
    }
}