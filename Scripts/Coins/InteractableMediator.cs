using UnityEngine;

public sealed class InteractableMediator : MonoBehaviour
{
    private UIHandler _uIHandler;
    private PlayerData _playerData;

    public void Init(PlayerData playerData, UIHandler uIHandler) 
    { 
        _playerData = playerData;
        _uIHandler = uIHandler;
    }

    public void Notify(Interactable interactable)
    {
        _playerData.AddCoins(interactable.interactableCoast);
        _uIHandler.CoinsCounter.OnNotify(_playerData.CoinsCount);
    }
}
