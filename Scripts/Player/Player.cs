using UnityEngine;

public sealed class Player : MonoBehaviour
{
    private IMovable _movable;

    public void Init(IMovable movable)
    {
        _movable = movable;
    }

    private void FixedUpdate()
    {
        _movable.InputMovement();
    }
}
