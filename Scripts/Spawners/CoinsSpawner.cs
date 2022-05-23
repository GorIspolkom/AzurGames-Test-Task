using UnityEngine;
using Zenject;

public sealed class CoinsSpawner : ISpawner
{
    private Transform[] _spawnPoints;
    private Interactable _interactable;
    private InteractableMediator _mediator;

    [Inject]
    public CoinsSpawner(Transform[] spawnPositions, Interactable interactable, InteractableMediator mediator)
    {
        _spawnPoints = spawnPositions;
        _interactable = interactable;
        _mediator = mediator;

        SpawnInteractables();
    }

    private void SpawnInteractables()
    {
        foreach (Transform point in _spawnPoints)
            Spawn(point.position);
    }

    public void Spawn(Vector3 spawnPosition)
    {
        Interactable interactable = Object.Instantiate(_interactable, spawnPosition, Quaternion.identity, null);
        interactable.Init(_mediator);
    }
}
