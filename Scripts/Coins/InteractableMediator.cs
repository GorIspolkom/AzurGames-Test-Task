using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class InteractableMediator : MonoBehaviour
{
    [SerializeField] private UIHandler _uIHandler;
    [SerializeField] private PlayerData _playerData;

    public void Notify(Interactable interactable)
    {
        _playerData.AddCoins(interactable.interactableCoast);
        _uIHandler.CoinsCounter.OnNotify(_playerData.CoinsCount);
    }
    private void Awake()
    {
        _playerData = new PlayerData();
        _uIHandler.CoinsCounter.OnNotify(_playerData.CoinsCount);
    }
}
