using System;

class Program
{
    static void Main(string[] args)
    {
        SimpleTrain train = new SimpleTrain(6); // Engine value is 6
        Domino d1 = new Domino(6, 5);
        Domino d2 = new Domino(5, 2);
        Domino d3 = new Domino(2, 3);

        Console.WriteLine("Initial train:");
        Console.WriteLine(train);

        Console.WriteLine("Playing dominos:");
        try
        {
            train.PlayDomino(d1);
            Console.WriteLine("Played: " + d1);
            train.PlayDomino(d2);
            Console.WriteLine("Played: " + d2);
            train.PlayDomino(d3);
            Console.WriteLine("Played: " + d3);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }

        Console.WriteLine("Final train:");
        Console.WriteLine(train);
    }
}
