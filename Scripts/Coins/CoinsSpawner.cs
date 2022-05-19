using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class CoinsSpawner : MonoBehaviour
{
    [SerializeField] private Transform[] _spawnPoints;
    [SerializeField] private Interactable _interactable;
    [SerializeField] private InteractableMediator mediator;

    private void SpawnInteractables()
    {
        foreach (Transform point in _spawnPoints)
        {
            Interactable ine =  Instantiate(_interactable, point.position, Quaternion.identity, null);
            ine.Init(mediator);
        }
           
    }

    private void Awake()
    {
        SpawnInteractables();
    }
}
