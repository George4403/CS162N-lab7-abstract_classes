public class SimpleTrain : Train
{
    public SimpleTrain() : base() { }

    public SimpleTrain(int engineValue) : base(engineValue) { }

    public override bool IsPlayable(Domino domino)
    {
        return IsDominoPlayable(domino, out _);
    }
}
