using UnityEngine;
using Zenject;

public sealed class CollectableUIInstaller : MonoInstaller
{
    [SerializeField] private UIPool _uIPool;
    private LevelLoader _levelLoader;
    private PlayerData _playerData;

    public override void InstallBindings()
    {
        _levelLoader = new LevelLoader();
        _playerData = new PlayerData();

        Container.Bind<LevelLoader>().FromInstance(_levelLoader);
        Container.Bind<PlayerData>().FromInstance(_playerData);
        Container.Bind<UIPool>().FromComponentOn(_uIPool.gameObject).AsSingle();

        Container.Bind<CollectableMediator>().AsSingle();
    }
}