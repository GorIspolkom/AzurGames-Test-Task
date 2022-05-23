using UnityEngine;
using Zenject;

public sealed class Player : MonoBehaviour
{
    private IMovable _movable;

    [Inject]
    public void Init(IMovable movable)
    {
        _movable = movable;
    }

    private void Update()
    {
        _movable.InputMovement();
    }
}
