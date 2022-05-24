using UnityEngine;
using Zenject;

public sealed class SpawnerInstaller : MonoInstaller
{
    [SerializeField] private Transform[] _spawnPoints;
    [SerializeField] private Interactable _interactable;
    [SerializeField] private InteractableMediator _mediator;

    public override void InstallBindings()
    {
        CoinsSpawnerData coinsSpawnerData = new CoinsSpawnerData(_spawnPoints, _interactable, _mediator);
        Container.Bind<ISpawner>().To<CoinsSpawner>().FromNew()
           .AsSingle().WithArguments(coinsSpawnerData).NonLazy();
    }
}