using UnityEngine;
using Zenject;
using System;

public class InputAdapter : MonoBehaviour
{
    private MouseAdapter _mouseAdapter;

    [Inject]
    public void Init(MouseMovementData mouseMovementData, Action<Vector3> moveAction)
    {
        _mouseAdapter = new MouseAdapter(mouseMovementData, moveAction);
    }

    private void Update()
    {
        ControllInput();
    }

    private void ControllInput()
    {
        if (Input.GetMouseButton(0))
           _mouseAdapter.ProcessMovement(Input.mousePosition);
    }
}

