using UnityEngine;
using Zenject;

public sealed class Player : MonoBehaviour
{
    private IMovable _movable;
    public IMovable Movable { get { return _movable; } }

    [Inject]
    public void Init(IMovable movable)
    {
        _movable = movable;
    }
}
