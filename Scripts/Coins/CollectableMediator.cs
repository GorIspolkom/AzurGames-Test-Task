using UnityEngine;
using Zenject;

public sealed class CollectableMediator : MonoBehaviour
{
    private UIPool _uIPool;
    private PlayerData _playerData;

    [Inject]
    public void Init(PlayerData playerData, UIPool uIPool) 
    { 
        _playerData = playerData;
        _uIPool = uIPool;
    }

    public void Notify(Collectable collectable)
    {
        _playerData.AddCoins(collectable.CollectableCoast);
        _uIPool.CoinsCounter.CoinsTextUpdate(_playerData.CoinsCount);
    }
}
