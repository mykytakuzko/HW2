namespace Task_1;

public class Money
{
    private int units;
    private int pennies;
    
    public Money() {}

    public Money(int units, int pennies)
    {
        this.units = units;
        this.pennies = pennies;
    }

    public int Units
    {
        get
        {
            return units;
        }
        set
        {
            units = value;
        }
    }

    public int Pennies
    {
        get
        {
            return pennies;
        }
        set
        {
            if (value >= 0 && value < 100)
            {
                pennies = value;
            }
            else
            {
                throw new ArgumentOutOfRangeException(nameof(Pennies));
            }
        }
    }

    public override string ToString()
    {
        return $"{units}.{pennies}";
    }
}