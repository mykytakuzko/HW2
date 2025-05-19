namespace Task_2;

public class Ukulele : MusicalInstrument
{
    public Ukulele(string name, string material, string size, int weight) : base(name, material, size, weight) {}
    
    public override void Desc()
    {
        Console.WriteLine($"{Name} — a small, four-stringed instrument resembling a guitar, known for its light, happy sound. Popular in Hawaiian and folk music.");
    }

    public override void History()
    {
        Console.WriteLine($"The {Name} was developed in the 19th century in Hawaii, based on Portuguese stringed instruments brought by immigrants. It gained global popularity in the 20th century.");
    }
}