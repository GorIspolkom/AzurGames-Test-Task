using UnityEngine;

public sealed class MouseMovement : IMovable
{
    private float _velocity;
    private float _xMin;
    private float _xMax;
    private Rigidbody _rb;
    private Animator _animator;

    public MouseMovement(float velocity, float xMin, float xMax, Rigidbody rb, Animator animator)
    {
        _velocity = velocity;
        _xMin = xMin;
        _xMax = xMax;
        _rb = rb;
        _animator = animator;
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
        _rb.velocity = movementVector * _velocity;
        _animator.SetFloat("Velocity", _rb.velocity.magnitude);
    }

    private Vector3 CalculateInput(Vector3 mousePos)
    {
        float xMousePos = 0f;

        Vector3 mousePosition = Camera.main.
            ScreenToViewportPoint(mousePos);

        if (mousePosition.x <= _xMin || mousePosition.x >= _xMax)
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
