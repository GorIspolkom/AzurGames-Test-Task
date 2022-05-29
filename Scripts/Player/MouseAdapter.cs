using UnityEngine;
using System;

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

    public Vector3 ProcessMovement(Tuple<Vector3, InputDirection> movementTuple)
    {

        if (!movementTuple.Item1.Equals(Vector3.zero))
        {
            if(movementTuple.Item2 == InputDirection.Yaw)
            {
                Vector3 mousePosition = Camera.main.ScreenToViewportPoint(movementTuple.Item1);

                float xMousePosition = mousePosition.x;

                if (mousePosition.x < 0.5f)
                    xMousePosition = -(1 - mousePosition.x);

                return new Vector3(xMousePosition, 0f, 0f) * _mouseMovementData.velocity;

            }
            return Vector3.forward * _mouseMovementData.velocity;
        }
        return Vector3.zero;
        
    }
}
