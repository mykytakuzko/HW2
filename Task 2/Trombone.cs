namespace Task_2;

public class Trombone : MusicalInstrument
{
    public Trombone(string name, string material, string size, int weight) : base(name, material, size, weight) {}
    
    public override void Desc()
    {
        Console.WriteLine($"{Name} — a brass wind instrument known for its telescoping slide mechanism that varies the length of the tube to change pitch.");
    }

    public override void History()
    {
        Console.WriteLine($"The {Name} dates back to the 15th century and evolved from the early sackbut. It became prominent in orchestras during the Classical period and is widely used in jazz and marching bands.");
    }
}