using UnityEngine;
using Zenject;

public sealed class InteractableMediator : MonoBehaviour
{
    private UIHandler _uIHandler;
    private PlayerData _playerData;

    [Inject]
    public void Init(PlayerData playerData, UIHandler uIHandler) 
    { 
        _playerData = playerData;
        _uIHandler = uIHandler;
    }

    public void Notify(Interactable interactable)
    {
        _playerData.AddCoins(interactable.InteractableCoast);
        _uIHandler.CoinsCounter.OnNotify(_playerData.CoinsCount);
    }
}
