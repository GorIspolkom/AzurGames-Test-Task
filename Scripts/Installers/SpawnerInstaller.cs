using UnityEngine;
using Zenject;

public sealed class SpawnerInstaller : MonoInstaller
{
    [SerializeField] private Transform[] _spawnPoints;
    [SerializeField] private Collectable _collectable;
    [SerializeField] private CollectableMediator _mediator;
    [SerializeField] private Transform _targetTransform;

    public override void InstallBindings()
    {
        CoinsSpawnerData coinsSpawnerData = new CoinsSpawnerData(_spawnPoints, _collectable, _mediator, _targetTransform);

        Container.Bind<ISpawner>().To<CoinsSpawner>().FromNew()
           .AsSingle().WithArguments(coinsSpawnerData, new EffectPool()).NonLazy();
    }
}