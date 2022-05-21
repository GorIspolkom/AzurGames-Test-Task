using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinEffect : MonoBehaviour
{
    [SerializeField] private ParticleSystem _particleSystem;
    [SerializeField] private float _particlesTime;

    private void Start()
    {
        _particleSystem.Play();
    }

    private void Update()
    {
        if (_particlesTime < 0f)
            Destroy(gameObject);
        _particlesTime -= Time.deltaTime;
    }
}
