public class PlayerTrain : Train
{
    public Hand Hand { get; }
    public bool IsOpen { get; private set; }

    public PlayerTrain(Hand hand, int engineValue) : base(engineValue)
    {
        Hand = hand;
    }

    public PlayerTrain(Hand hand) : base(0)
    {
        Hand = hand;
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

    public void Open()
    {
        IsOpen = true;
    }

    public void Close()
    {
        IsOpen = false;
    }

    public bool IsOpenState()
    {
        return IsOpen;
    }
}
