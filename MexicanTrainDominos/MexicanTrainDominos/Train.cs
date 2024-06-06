using System;
using System.Collections.Generic;
using System.Text;

public abstract class Train
{
    protected List<Domino> dominos;
    public int EngineValue { get; private set; }

    protected Train()
    {
        dominos = new List<Domino>();
    }

    protected Train(int engineValue) : this()
    {
        EngineValue = engineValue;
    }

    public int Count => dominos.Count;

    public bool IsEmpty => dominos.Count == 0;

    public Domino LastDomino => IsEmpty ? null : dominos[dominos.Count - 1];

    public int PlayableValue => IsEmpty ? EngineValue : LastDomino.Side2;

    public Domino GetDomino(int index)
    {
        if (index < 0 || index >= dominos.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }
        return dominos[index];
    }

    public bool IsDominoPlayable(Domino domino, out bool mustFlip)
    {
        if (domino.Side1 == PlayableValue)
        {
            mustFlip = false;
            return true;
        }
        if (domino.Side2 == PlayableValue)
        {
            mustFlip = true;
            return true;
        }
        mustFlip = false;
        return false;
    }

    public void PlayDomino(Domino domino)
    {
        if (IsDominoPlayable(domino, out bool mustFlip))
        {
            if (mustFlip)
            {
                domino.Flip();
            }
            dominos.Add(domino);
        }
        else
        {
            throw new InvalidOperationException("Domino is not playable on this train.");
        }
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        foreach (var domino in dominos)
        {
            sb.Append(domino).Append(" ");
        }
        return sb.ToString().Trim();
    }

    public abstract bool IsPlayable(Domino domino);
}
