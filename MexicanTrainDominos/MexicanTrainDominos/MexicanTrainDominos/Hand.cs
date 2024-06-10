using System.Collections;
using System.Collections.Generic;

public class Hand : IEnumerable<Domino>
{
    private List<Domino> dominos = new List<Domino>();

    public void Add(Domino domino)
    {
        dominos.Add(domino);
    }

    public IEnumerator<Domino> GetEnumerator()
    {
        return dominos.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
