public class Domino
{
    public int Side1 { get; private set; }
    public int Side2 { get; private set; }

    public Domino(int side1, int side2)
    {
        Side1 = side1;
        Side2 = side2;
    }

    public void Flip()
    {
        int temp = Side1;
        Side1 = Side2;
        Side2 = temp;
    }

    public override string ToString()
    {
        return $"{Side1}|{Side2}";
    }

    public override bool Equals(object obj)
    {
        if (obj is Domino otherDomino)
        {
            return (Side1 == otherDomino.Side1 && Side2 == otherDomino.Side2) ||
                   (Side1 == otherDomino.Side2 && Side2 == otherDomino.Side1);
        }
        return false;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Side1, Side2);
    }
}
