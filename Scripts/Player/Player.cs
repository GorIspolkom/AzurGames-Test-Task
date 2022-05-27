using UnityEngine;
using Zenject;
using System;

public sealed class Player : MonoBehaviour
{
    public Action<Vector3> PlayerAction;

    private IMovable _movable;

    [Inject]
    public void Init(IMovable movable)
    {
        _movable = movable;
        PlayerAction = _movable.InputMovement;
        Debug.Log(PlayerAction.Method);
    }
}
