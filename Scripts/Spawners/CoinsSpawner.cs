using UnityEngine;
using Zenject;

public struct CoinsSpawnerData
{
    public Transform[] spawnPoints;
    public Interactable interactable;
    public InteractableMediator mediator;

    public CoinsSpawnerData(Transform[] spawnPoints, Interactable interactable, InteractableMediator mediator)
    {
        this.spawnPoints = spawnPoints;
        this.interactable = interactable;
        this.mediator = mediator;
    }
}

public sealed class CoinsSpawner : ISpawner
{
    private readonly CoinsSpawnerData _coinsSpawnerData;

    [Inject]
    public CoinsSpawner(CoinsSpawnerData coinsSpawnerData)
    {
        _coinsSpawnerData = coinsSpawnerData;
        SpawnInteractables();
    }

    private void SpawnInteractables()
    {
        foreach (Transform point in _coinsSpawnerData.spawnPoints)
            Spawn(point.position);
    }

    public void Spawn(Vector3 spawnPosition)
    {
        Interactable interactable = Object.Instantiate(_coinsSpawnerData.interactable, spawnPosition, Quaternion.identity, null);
        interactable.Init(_coinsSpawnerData.mediator);
    }
}
