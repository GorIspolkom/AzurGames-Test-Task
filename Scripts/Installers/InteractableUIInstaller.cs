using UnityEngine;
using Zenject;

public class InteractableUIInstaller : MonoInstaller
{
    [SerializeField] private UIHandler _uIHandler;
    private LevelLoader _levelLoader;
    private PlayerData _playerData;

    public override void InstallBindings()
    {
        _levelLoader = new LevelLoader();
        _playerData = new PlayerData();

        Container.Bind<LevelLoader>().FromInstance(_levelLoader);
        Container.Bind<PlayerData>().FromInstance(_playerData);
        Container.Bind<UIHandler>().FromComponentOn(_uIHandler.gameObject).AsSingle();

        Container.Bind<InteractableMediator>().AsSingle();
    }

    private void Awake()
    {
        _uIHandler.CoinsCounter.OnNotify(_playerData.CoinsCount);
    }
}