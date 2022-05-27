using UnityEngine;

public struct MouseMovementData
{
    public float velocity;
    public float xMin;
    public float xMax;

    public MouseMovementData(float velocity, float xMin, float xMax)
    {
        this.velocity = velocity;
        this.xMin = xMin;
        this.xMax = xMax;
    }
}

public struct PlayerMovementComponents
{
    public CharacterController characterController;
    public Animator animator;

    public PlayerMovementComponents(CharacterController characterController, Animator animator)
    {
        this.characterController = characterController;
        this.animator = animator;
    }
}

public sealed class MouseMovement : IMovable
{
    private readonly MouseMovementData _mouseMovementData;
    private readonly PlayerMovementComponents _playerMovementComponents;

    public MouseMovement(MouseMovementData mouseMovementData, PlayerMovementComponents playerMovementComponents)
    {
        _mouseMovementData = mouseMovementData;
        _playerMovementComponents = playerMovementComponents;
    }

    public void InputMovement(Vector3 movementVector)
    {
        if (movementVector.Equals(Vector3.zero))
            Move(movementVector);
        else
            Move(CalculateInput(movementVector));
    }

    private void Move(Vector3 movementVector)
    {
        Debug.Log((movementVector * _mouseMovementData.velocity).magnitude);
        _playerMovementComponents.characterController.Move(movementVector * _mouseMovementData.velocity);
        _playerMovementComponents.animator.SetFloat("Velocity", (movementVector * _mouseMovementData.velocity).magnitude);
    }

    private Vector3 CalculateInput(Vector3 mousePos)
    {
        float xMousePos = 0f;

        Vector3 mousePosition = Camera.main.
            ScreenToViewportPoint(mousePos);

        if (mousePosition.x <= _mouseMovementData.xMin || mousePosition.x >= _mouseMovementData.xMax)
        {
            xMousePos = mousePosition.x;

            if (mousePosition.x < 0.5)
                xMousePos = -(1 - mousePosition.x);

            return (new Vector3(0f, 0f, Vector3.forward.z - 0.4f) + new Vector3(xMousePos, 0f, 0f)).normalized;
        }
        else
            return Vector3.forward.normalized;

    }
}
