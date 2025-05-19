namespace Task_3;

class Program
{
    static void Main(string[] args)
    {
        DecimalNumber decimalNumber = new DecimalNumber(452);
        
        string binary = decimalNumber.toBinarySystem();
        Console.WriteLine(binary);
        
        string octal = decimalNumber.toOctalSystem();
        Console.WriteLine(octal);
        
        string hexadecimal = decimalNumber.toHexadecimalSystem();
        Console.WriteLine(hexadecimal);
    }
}