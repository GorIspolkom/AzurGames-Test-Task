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

public class MouseAdapter
{
    private readonly MouseMovementData _mouseMovementData;
    private readonly Action<Vector3> _moveAction;

    public MouseAdapter(MouseMovementData mouseMovementData, Action<Vector3> moveAction)
    {
        _mouseMovementData = mouseMovementData;
        _moveAction = moveAction;
    }

    public void ProcessMovement(Vector3 mousePosition)
    {
        float xMousePos = 0f;

        mousePosition = Camera.main.ScreenToViewportPoint(mousePosition);

        if (mousePosition.x <= _mouseMovementData.xMin || mousePosition.x >= _mouseMovementData.xMax)
        {
            xMousePos = mousePosition.x;

            if (mousePosition.x < 0.5)
                xMousePos = -(1 - mousePosition.x);

            _moveAction?.Invoke(new Vector3(0f, 0f, Vector3.forward.z - 0.4f) + 
                new Vector3(xMousePos, 0f, 0f) * _mouseMovementData.velocity);
        }
        else
            _moveAction?.Invoke(Vector3.forward * _mouseMovementData.velocity);
    }
}
