using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create some dominoes
        Domino d1 = new Domino(6, 5);
        Domino d2 = new Domino(5, 4);
        Domino d3 = new Domino(4, 3);
        Domino d4 = new Domino(3, 2);

        // Create a hand and add dominoes
        Hand hand = new Hand();
        hand.Add(d1);
        hand.Add(d2);
        hand.Add(d3);
        hand.Add(d4);

        // Create a Mexican train with engine value 6
        MexicanTrain mexicanTrain = new MexicanTrain(6);
        Console.WriteLine($"Mexican Train is empty: {mexicanTrain.IsEmpty}");

        // Play a domino on the Mexican train
        mexicanTrain.PlayDomino(d1);
        Console.WriteLine($"Mexican Train after playing {d1}: {mexicanTrain}");

        // Create a player train with engine value 6
        PlayerTrain playerTrain = new PlayerTrain(hand, 6);
        Console.WriteLine($"Player Train is empty: {playerTrain.IsEmpty}");

        // Play a domino on the player train
        playerTrain.PlayDomino(d1);
        Console.WriteLine($"Player Train after playing {d1}: {playerTrain}");

        // Open and close the player train
        playerTrain.Open();
        Console.WriteLine($"Player Train is open: {playerTrain.IsOpenState()}");
        playerTrain.Close();
        Console.WriteLine($"Player Train is open: {playerTrain.IsOpenState()}");

        // Sort and display the hand of dominos
        List<Domino> sortedDominos = new List<Domino>(hand);
        sortedDominos.Sort();
        Console.WriteLine("Sorted dominos in hand:");
        foreach (var domino in sortedDominos)
        {
            Console.WriteLine(domino);
        }
    }
}
