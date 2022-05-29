using UnityEngine;
using System;

public enum InputDirection
{
    Forward,
    Yaw
}

public sealed class InputAdapter
{
    private Vector3 _touchDownPosition;
    private Vector3 _touchUpPosition;

    public Tuple<Vector3, InputDirection> ControllInput()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                _touchUpPosition = touch.position;
                _touchDownPosition = touch.position;
                return new Tuple<Vector3, InputDirection>(Vector3.forward, InputDirection.Forward);
            }

            if (touch.phase == TouchPhase.Stationary)
            {
                _touchUpPosition = touch.position;
                _touchDownPosition = touch.position;
                return new Tuple<Vector3, InputDirection>(Vector3.forward, InputDirection.Forward);
            }

            if (touch.phase == TouchPhase.Moved)
            {
                _touchDownPosition = touch.position;
            }

            if (touch.phase == TouchPhase.Ended)
            {
                _touchDownPosition = touch.position;
            }

            return new Tuple<Vector3, InputDirection>(_touchDownPosition - _touchUpPosition, InputDirection.Yaw);
        }

        return new Tuple<Vector3, InputDirection>(Vector3.zero, InputDirection.Forward);
    }

        //if (Input.GetKey(KeyCode.W))
        //{
        //    _inputPosition = Input.mousePosition;
        //    return new Tuple<Vector3, InputDirection>(_inputPosition, InputDirection.Forward);
        //}

        //if (Input.GetMouseButton(0))
        //    return new Tuple<Vector3, InputDirection>(_inputPosition - Input.mousePosition, InputDirection.Yaw);

        //return new Tuple<Vector3, InputDirection>(Vector3.zero, InputDirection.Forward);

}

