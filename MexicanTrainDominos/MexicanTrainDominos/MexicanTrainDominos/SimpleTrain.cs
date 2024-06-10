public class MexicanTrain : Train
{
    public MexicanTrain(int engineValue) : base(engineValue)
    {
    }

    public override bool IsPlayable(Domino domino, out bool mustFlip)
    {
        mustFlip = false;
        if (domino.Side1 == LastPlayableValue)
            return true;
        if (domino.Side2 == LastPlayableValue)
        {
            mustFlip = true;
            return true;
        }
        return false;
    }
}
