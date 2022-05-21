using UnityEngine;

public abstract class Movable : MonoBehaviour
{
    public abstract void InputMovement();
    public abstract void Move(Vector3 movementVector);
}
