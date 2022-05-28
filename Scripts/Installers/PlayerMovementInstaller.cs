using UnityEngine;
using Zenject;

public sealed class PlayerMovementInstaller : MonoInstaller
{
    [SerializeField] private float _velocity;
    [SerializeField] private float _xMin;
    [SerializeField] private float _xMax;

    [SerializeField] private CharacterController _characterController;
    [SerializeField] private Animator _animator;

    public override void InstallBindings()
    {
        MouseMovementData mouseMovementData = new MouseMovementData(_velocity, _xMin, _xMax);

        PlayerMovementComponents playerMovementComponents = new 
            PlayerMovementComponents(_characterController, _animator);

        MouseMovement mouseMovement = new MouseMovement(playerMovementComponents);

        Player player = new Player(mouseMovement);

        InputAdapter inputAdapter = new InputAdapter();

        MouseAdapter mouseAdapter = new MouseAdapter(mouseMovementData);

        MovementKeeperComponents movementKeeperComponents = new MovementKeeperComponents(player, mouseAdapter, inputAdapter);

        Container.Bind<MovementKeeperComponents>().FromInstance(movementKeeperComponents);

        Container.Bind<MovementKeeper>().AsSingle();
    }
}