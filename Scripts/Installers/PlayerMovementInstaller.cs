using UnityEngine;
using Zenject;

public sealed class PlayerMovementInstaller : MonoInstaller
{
    [SerializeField] private float _velocity;
    [SerializeField] private float _xMin;
    [SerializeField] private float _xMax;
    [SerializeField] private Rigidbody _rb;
    [SerializeField] private Animator _animator;

    public override void InstallBindings()
    {
        MouseMovementData mouseMovementData = new MouseMovementData(_velocity, _xMin, _xMax, _rb, _animator);

        Container.Bind<IMovable>().To<MouseMovement>().FromNew()
            .AsSingle().WithArguments(mouseMovementData);
    }
}