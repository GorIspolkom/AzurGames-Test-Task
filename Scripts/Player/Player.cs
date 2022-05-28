public sealed class Player
{
    private IMovable _movable;

    public IMovable Movable { get { return _movable; } }

    public Player(IMovable movable)
    {
        _movable = movable;
    }
}
