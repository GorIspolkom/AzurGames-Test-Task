using UnityEngine;
using Zenject;
using System;

public sealed class PlayerMovementInstaller : MonoInstaller
{
    [SerializeField] private float _velocity;
    [SerializeField] private float _xMin;
    [SerializeField] private float _xMax;

    [SerializeField] private Player _player;
    [SerializeField] private CharacterController _characterController;
    [SerializeField] private Animator _animator;

    public override void InstallBindings()
    {
        MouseMovementData mouseMovementData = new MouseMovementData(_velocity, _xMin, _xMax);

        PlayerMovementComponents playerMovementComponents = new 
            PlayerMovementComponents(_characterController, _animator);

        Container.Bind<MouseMovementData>().FromInstance(mouseMovementData);

        Container.Bind<IMovable>().To<MouseMovement>().FromNew()
            .AsSingle().WithArguments(playerMovementComponents);

        Container.Bind<Action<Vector3>>().FromInstance(_player.PlayerAction);

        //Debug.Log(_player.PlayerAction.Method);

        Container.Bind<InputAdapter>().AsSingle();
    }
}