namespace Task_2;

public class Cello : MusicalInstrument
{
    public Cello(string name, string material, string size, int weight) : base(name, material, size, weight) {}
    
    public override void Desc()
    {
        Console.WriteLine($"{Name} — a large bowed string instrument with a deep, mellow tone, used in orchestras and chamber music.");
    }

    public override void History()
    {
        Console.WriteLine($"The {Name} developed in the 16th century in Italy as part of the violin family. It became essential in Baroque and Classical compositions.");
    }
}