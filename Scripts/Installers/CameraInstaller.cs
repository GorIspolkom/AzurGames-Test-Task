using UnityEngine;
using Zenject;

public class CameraInstaller : MonoInstaller
{
    [SerializeField] private Transform _targetTransform;
    [SerializeField] private Vector3 _offset;
    [SerializeField] private float _smoothVelocity;

    public override void InstallBindings()
    {
        Container.Bind<Transform>().FromInstance(_targetTransform);
        Container.Bind<Vector3>().FromInstance(_offset);
        Container.Bind<float>().FromInstance(_smoothVelocity);

        Container.Bind<FollowCamera>().AsSingle();
    }
}