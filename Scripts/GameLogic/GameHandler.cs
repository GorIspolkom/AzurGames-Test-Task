using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class GameHandler : MonoBehaviour
{
    [SerializeField] private InteractableMediator _interactableMediator;
    [SerializeField] private UIHandler _uIHandler;
    [SerializeField] private Player _player;
    [SerializeField] private FollowCamera _followCamera;
    [SerializeField] private Transform[] _spawnPositions;
    [SerializeField] private Interactable _interactable;

    private CoinsSpawner _coinsSpawner;
    private LevelManager _levelManager;
    private PlayerData _playerData;

    private void Awake()
    {
        _playerData = new PlayerData();
        _levelManager = new LevelManager();
        _uIHandler.Init(_levelManager);
        _interactableMediator.Init(_playerData, _uIHandler);
        _coinsSpawner = new CoinsSpawner(_spawnPositions, _interactable, _interactableMediator);
        _player.Init(new MouseMovement(10f, 0.4f, 0.6f, _player.GetComponent<Rigidbody>()));
        _followCamera.Init(_player.transform);
        _coinsSpawner.SpawnInteractables();
        _uIHandler.CoinsCounter.OnNotify(_playerData.CoinsCount);
    }
}
