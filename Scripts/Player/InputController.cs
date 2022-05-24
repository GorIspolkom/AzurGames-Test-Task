using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{
    [SerializeField] private Player _player;

    private void Update()
    {
        ControllInput();
    }

    private void ControllInput()
    {
        if (Input.GetMouseButton(0))
            _player.Movable.InputMovement(Input.mousePosition);
        else
            _player.Movable.InputMovement(Vector3.zero);
    }
}
