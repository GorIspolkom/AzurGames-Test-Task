using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class GameHandler : MonoBehaviour
{
    [SerializeField] private InteractableMediator _interactableMediator;
    [SerializeField] private UIHandler _uIHandler;
    private LevelManager _levelManager;
    private PlayerData _playerData;

    private void Awake()
    {
        _playerData = new PlayerData();
        _levelManager = new LevelManager();
        _uIHandler.Init(_levelManager.OpenNextLevel);
        _interactableMediator.Init(_playerData, _uIHandler);
    }
}
