using UnityEngine;

public sealed class Player : MonoBehaviour
{
    [SerializeField] private Movable _movable;

    private void FixedUpdate()
    {
        _movable.InputMovement();
    }
}
