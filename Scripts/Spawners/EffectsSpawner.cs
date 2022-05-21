using UnityEngine;

public class EffectsSpawner : Spawner
{
    [SerializeField] private CoinEffect _coinsEffect;

    public override void Spawn(Vector3 spawnPositon) =>
        Instantiate(_coinsEffect, spawnPositon, Quaternion.identity, null);
}
