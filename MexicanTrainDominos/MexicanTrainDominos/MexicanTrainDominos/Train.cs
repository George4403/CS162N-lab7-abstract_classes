using System;
using System.Collections.Generic;

public abstract class Train
{
    protected List<Domino> dominos = new List<Domino>();
    public int EngineValue { get; }

    protected Train(int engineValue)
    {
        EngineValue = engineValue;
    }

    public int Count => dominos.Count;

    public bool IsEmpty => dominos.Count == 0;

    public Domino LastDomino => dominos[dominos.Count - 1];

    public int LastPlayableValue => IsEmpty ? EngineValue : LastDomino.Side2;

    public Domino this[int index] => dominos[index];

    public void PlayDomino(Domino domino)
    {
        if (!IsPlayable(domino, out bool mustFlip))
            throw new InvalidOperationException("Domino is not playable on this train.");

        if (mustFlip)
            domino = new Domino(domino.Side2, domino.Side1);

        dominos.Add(domino);
    }

    public abstract bool IsPlayable(Domino domino, out bool mustFlip);

    public override string ToString()
    {
        return string.Join(" ", dominos);
    }
}
