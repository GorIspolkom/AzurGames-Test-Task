using UnityEngine;

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
    private readonly PlayerMovementComponents _playerMovementComponents;

    public MouseMovement(PlayerMovementComponents playerMovementComponents)
    {
        _playerMovementComponents = playerMovementComponents;
    }

    public void InputMovement(Vector3 movementVector)
    {
        Move(movementVector);
    }

    private void Move(Vector3 movementVector)
    {
        _playerMovementComponents.characterController.Move(movementVector);
        _playerMovementComponents.animator.SetFloat("Velocity", movementVector.magnitude);
    }
}
