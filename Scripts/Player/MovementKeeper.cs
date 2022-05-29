using UnityEngine;
using Zenject;
using System;

public struct MovementKeeperComponents
{
    public Player player;
    public MouseAdapter mouseAdapter;
    public InputAdapter inputAdapter;

    public MovementKeeperComponents(Player player, MouseAdapter mouseAdapter, InputAdapter inputAdapter)
    {
        this.player = player;
        this.mouseAdapter = mouseAdapter;
        this.inputAdapter = inputAdapter;
    }
}

public sealed class MovementKeeper : MonoBehaviour
{
    private MovementKeeperComponents _movementKeeperComponents;

    [Inject]
    public void Init(MovementKeeperComponents movementKeeperComponents)
    {
        _movementKeeperComponents = movementKeeperComponents;
    }

    private void Update()
    {
        MotionProcessing();
    }

    private void MotionProcessing()
    {
        Tuple<Vector3, InputDirection> inputData = _movementKeeperComponents.inputAdapter.ControllInput();
        Vector3 processedData = _movementKeeperComponents.mouseAdapter.ProcessMovement(inputData);
        _movementKeeperComponents.player.Movable.InputMovement(processedData);
    }
}
