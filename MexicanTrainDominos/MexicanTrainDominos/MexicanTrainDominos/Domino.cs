using System;

public class Domino : IComparable<Domino>
{
    public int Side1 { get; set; }
    public int Side2 { get; set; }

    public int Score => Side1 + Side2;

    public Domino(int side1, int side2)
    {
        Side1 = side1;
        Side2 = side2;
    }

    public int CompareTo(Domino other)
    {
        return this.Score.CompareTo(other.Score);
    }

    public override string ToString()
    {
        return $"[{Side1}|{Side2}]";
    }
}
