namespace Task_2;

public class MusicalInstrument
{
    public string Name { get; set; }
    public string Material { get; set; }
    public string Size { get; set; }
    public int Weight { get; set; }
    
    public MusicalInstrument() {}

    public MusicalInstrument(string name, string material, string size, int weight)
    {
        Name = name;
        Material = material;
        Size = size;
        Weight = weight;
    }

    public virtual void Show()
    {
        Console.WriteLine($"Name: {Name}\nMaterial: {Material}\nSize: {Size}\nWeight: {Weight}");
    }

    public virtual void Sound()
    {
        Console.WriteLine($"Sound of {Name}");
    }
    
    public virtual void Desc() {}
    public virtual void History() {}
}