namespace Task_2;

class Program
{
    static void Main(string[] args)
    {
        MusicalInstrument violin = new Violin("Violin", "Wood", "Full", 1);
        violin.Show();
        violin.Sound();
        violin.Desc();
        violin.History();
        
        Console.WriteLine("–––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––");

        MusicalInstrument trombone = new Trombone("Trombone", "Brass", "Large", 3);
        trombone.Show();
        trombone.Sound();
        trombone.Desc();
        trombone.History();
        
        Console.WriteLine("–––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––");
        
        MusicalInstrument ukulele = new Ukulele("Ukulele", "Wood", "Small", 1);
        ukulele.Show();
        ukulele.Sound();
        ukulele.Desc();
        ukulele.History();
        
        Console.WriteLine("–––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––");
        
        MusicalInstrument cello = new Cello("Cello", "Wood", "Large", 4);
        cello.Show();
        cello.Sound();
        cello.Desc();
        cello.History();
    }
}