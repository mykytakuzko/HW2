namespace Task_3;

public struct DecimalNumber
{
    private int decimalNumber;

    public DecimalNumber(int decimalNumber)
    {
        this.decimalNumber = decimalNumber;
    }

    public string toBinarySystem()
    {
        return Convert.ToString(decimalNumber, 2);
    }

    public string toOctalSystem()
    {
        return Convert.ToString(decimalNumber, 8);
    }

    public string toHexadecimalSystem()
    {
        return Convert.ToString(decimalNumber, 16);
    }
}