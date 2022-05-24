using UnityEngine;

public interface IMovable
{
    public void InputMovement(Vector3 movementVector);
    public void Move(Vector3 movementVector);
}
