using UnityEngine;

public sealed class InputAdapter
{
    public Vector3 ControllInput()
    {
        if (Input.GetMouseButton(0))
            return Input.mousePosition;
        return Vector3.zero;
    }
}

