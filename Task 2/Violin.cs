namespace Task_2;

public class Violin : MusicalInstrument
{
    public Violin(string name, string material, string size, int weight) : base(name, material, size, weight) {}
    
    public override void Desc()
    {
        Console.WriteLine($"{Name} — a small, four-stringed bowed instrument known for its bright, expressive tone. It is widely used in classical music, orchestras, and solo performances");
    }

    public override void History()
    {
        Console.WriteLine($"The {Name} originated in early 16th-century Italy. It evolved from earlier bowed instruments like the medieval fiddle and rebec. By the 17th century, it became central to classical music, with famous makers like Stradivari and Guarneri refining its design");
    }
}