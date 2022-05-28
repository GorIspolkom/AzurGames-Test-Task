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

public sealed class MouseAdapter
{
    private readonly MouseMovementData _mouseMovementData;

    public MouseAdapter(MouseMovementData mouseMovementData)
    {
        _mouseMovementData = mouseMovementData;
    }

    public Vector3 ProcessMovement(Vector3 mousePosition)
    {
        if (!mousePosition.Equals(Vector3.zero))
        {
            float xMousePos = 0f;

            mousePosition = Camera.main.ScreenToViewportPoint(mousePosition);

            if (mousePosition.x <= _mouseMovementData.xMin || mousePosition.x >= _mouseMovementData.xMax)
            {
                xMousePos = mousePosition.x;

                if (mousePosition.x < 0.5)
                    xMousePos = -(1 - mousePosition.x);

                return (new Vector3(0f, 0f, Vector3.forward.z - 0.2f) +
                   new Vector3(xMousePos, 0f, 0f)) * _mouseMovementData.velocity;
            }
            else
                return Vector3.forward * _mouseMovementData.velocity;
        }
        return Vector3.zero;
        
    }
}
