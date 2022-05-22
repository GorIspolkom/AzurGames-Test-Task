using UnityEngine;

public interface IMovable
{
    public void InputMovement();
    public void Move(Vector3 movementVector);
}
