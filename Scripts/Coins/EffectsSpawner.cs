using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectsSpawner : MonoBehaviour
{
    [SerializeField] private CoinEffect _coinsEffect;

    public void SpawnParticle(Vector3 spawnPositon) =>
        Instantiate(_coinsEffect, spawnPositon, Quaternion.identity, null);
}
