namespace Task_1;

class Program
{
    static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("Hello! You can look how it works automatically or use it yourself: Automatically | Manually");
        Console.ResetColor();
        
        string input = GetAnswerForTheFirstQuestion();

        if (input.Equals("Automatically"))
        {
            RunAutomatically();
        }
        else
        {
            RunManually();
        }
    }

    private static string GetAnswerForTheFirstQuestion()
    {
        string result;

        while (true)
        {
            result = Console.ReadLine();
            if (!result.Equals("Automatically") && !result.Equals("Manually"))
            {
                Console.WriteLine("You must write 'Automatically' or 'Manually'");
            }
            else
            {
                return result;
            }
        }
    }

    private static void RunAutomatically()
    {
        Console.WriteLine("Create a product 'Test product'");
        Product testProduct = new Product();
        testProduct.Name = "Test product";
        Console.WriteLine("Set the price '5.45'");
        testProduct.Price = new Money(5, 45);
        Console.WriteLine("Show created product\n–––––––––––––––––––––");
        Console.WriteLine($"{testProduct}\n–––––––––––––––––––––");
        Console.WriteLine("Take price 2.18 less");
        testProduct.TakePriceLess(2.18);
        Console.WriteLine("Show new price of product\n–––––––––––––––––––––");
        Console.WriteLine($"Price: {testProduct.Price}");
    }

    private static void RunManually()
    {
        Console.Write("Enter the name of the product: ");
        string name = GetDataFromConsole("Enter the name of the product");
        Console.Write("Enter the whole part of the price: ");
        int units = GetNumberFromConsole("Price must be a number", "Enter the whole part of the price");
        Console.Write("Enter the pennies of the price: ");
        int pennies = GetNumberFromConsole("Price must be a number", "Enter the pennies of the price");
        Product product = new Product(name, new Money(units, pennies));
        Console.WriteLine("Show created product\n–––––––––––––––––––––");
        Console.WriteLine($"{product}\n–––––––––––––––––––––");
        Console.Write("Enter a price for reduction: ");
        int priceReduction = GetNumberFromConsole("Reduction must be a number", "Enter a price for reduction");
        product.TakePriceLess(priceReduction);
        Console.WriteLine("Show new price of product\n–––––––––––––––––––––");
        Console.WriteLine($"Price: {product.Price}");
    }

    private static string GetDataFromConsole(string errorText)
    {
        string result;

        while (true)
        {
            result = Console.ReadLine();
            if (result.Length != 0)
            {
                return result;
            }
            else
            {
                Console.Write($"You must enter a data. {errorText}: ");
            }
        }
    }

    private static int GetNumberFromConsole(string exceptionError, string consoleError)
    {
        int units;
        
        while (true)
        {
            try
            {
                units = Int32.Parse(GetDataFromConsole(consoleError));
                return units;
            }
            catch (Exception e)
            {
                Console.Write($"{exceptionError}. {consoleError}: ");
            }
        }
    }
}