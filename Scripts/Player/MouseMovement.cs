using UnityEngine;

public sealed class MouseMovement : Movable
{
    [SerializeField] private float _velocity;
    [SerializeField] private float _xMin;
    [SerializeField] private float _xMax;
    private Rigidbody _rb;

    public override void InputMovement()
    {
        if (Input.GetMouseButton(1))
            Move(CalculateInput());
        else
            Move(Vector3.zero);
    }

    public override void Move(Vector3 movementVector)
    {
        _rb.velocity = movementVector * _velocity;
    }

    private Vector3 CalculateInput()
    {
        float xMousePos = 0f;

        Vector3 mousePosition = Camera.main.
            ScreenToViewportPoint(Input.mousePosition);

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

    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    }
}
