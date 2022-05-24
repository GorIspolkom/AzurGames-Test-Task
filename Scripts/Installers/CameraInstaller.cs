using UnityEngine;
using Zenject;

public sealed class CameraInstaller : MonoInstaller
{
    [SerializeField] private Transform _targetTransform;
    [SerializeField] private Vector3 _offset;
    [SerializeField] private float _smoothVelocity;

    public override void InstallBindings()
    {
        FollowCameraData followCameraData = new FollowCameraData(_targetTransform, _offset, _smoothVelocity);

        Container.Bind<FollowCameraData>().FromInstance(followCameraData);

        Container.Bind<FollowCamera>().AsSingle();
    }
}