using UnityEngine;
using Zenject;

public struct CoinsSpawnerData
{
    public Transform[] spawnPoints;
    public Transform targetTransform;
    public Collectable collectable;
    public CollectableMediator mediator;

    public CoinsSpawnerData(Transform[] spawnPoints, Collectable collectable, CollectableMediator mediator, Transform targetTransform)
    {
        this.spawnPoints = spawnPoints;
        this.targetTransform = targetTransform;
        this.collectable = collectable;
        this.mediator = mediator;
    }
}

public sealed class CoinsSpawner : ISpawner
{
    private readonly CoinsSpawnerData _coinsSpawnerData;
    private readonly EffectPool _effectPool;

    [Inject]
    public CoinsSpawner(CoinsSpawnerData coinsSpawnerData, EffectPool effectPool)
    {
        _coinsSpawnerData = coinsSpawnerData;
        _effectPool = effectPool;
        SpawnCollectable();
    }

    private void SpawnCollectable()
    {
        foreach (Transform point in _coinsSpawnerData.spawnPoints)
            Spawn(point.position);
    }

    public void Spawn(Vector3 spawnPosition)
    {
        Collectable collectable = Object.Instantiate(_coinsSpawnerData.collectable, spawnPosition, Quaternion.identity, null);
        collectable.Init(_coinsSpawnerData.mediator, _effectPool, _coinsSpawnerData.targetTransform);
    }
}
