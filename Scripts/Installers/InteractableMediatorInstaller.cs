using UnityEngine;
using Zenject;

public class InteractableMediatorInstaller : MonoInstaller
{
    [SerializeField] private UIHandler _uIHandler;
    [SerializeField] private InteractableMediator mediator;
    private PlayerData _playerData;

    public override void InstallBindings()
    {
        Container.Bind<InteractableMediator>().AsSingle();
    }

    private void Awake()
    {
        _playerData = new PlayerData();
    }
}