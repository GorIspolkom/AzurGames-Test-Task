using UnityEngine;

public struct MouseMovementData
{
    public float velocity;
    public float xMin;
    public float xMax;
    public Rigidbody rb;
    public Animator animator;

    public MouseMovementData(float velocity, float xMin, float xMax, Rigidbody rb, Animator animator)
    {
        this.velocity = velocity;
        this.xMin = xMin;
        this.xMax = xMax;
        this.rb = rb;
        this.animator = animator;
    }
}

public sealed class MouseMovement : IMovable
{
    private readonly MouseMovementData _mouseMovementData;

    public MouseMovement(MouseMovementData mouseMovementData)
    {
        _mouseMovementData = mouseMovementData;
    }

    public void InputMovement(Vector3 movementVector)
    {
        if (movementVector != Vector3.zero)
            Move(CalculateInput(movementVector));
        else
            Move(movementVector);
    }

    public void Move(Vector3 movementVector)
    {
        _mouseMovementData.rb.velocity = movementVector * _mouseMovementData.velocity;
        _mouseMovementData.animator.SetFloat("Velocity", _mouseMovementData.rb.velocity.magnitude);
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

            return new Vector3(xMousePos, 0f, 1f);
        }
        else
            return Vector3.forward;

    }
}
