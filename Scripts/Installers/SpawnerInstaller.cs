using UnityEngine;
using Zenject;

public sealed class SpawnerInstaller : MonoInstaller
{
    [SerializeField] private Transform[] _spawnPoints;
    [SerializeField] private Interactable _interactable;
    [SerializeField] private InteractableMediator _mediator;

    public override void InstallBindings()
    {
        Container.Bind<ISpawner>().To<CoinsSpawner>().FromNew()
           .AsSingle().WithArguments(_spawnPoints, _interactable, _mediator).NonLazy();
    }
}