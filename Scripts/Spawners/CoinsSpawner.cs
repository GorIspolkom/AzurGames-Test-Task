using UnityEngine;

public sealed class CoinsSpawner : ISpawner
{
    private Transform[] _spawnPoints;
    private Interactable _interactable;
    private InteractableMediator _mediator;

    public CoinsSpawner(Transform[] spawnPositions, Interactable interactable, InteractableMediator mediator)
    {
        _spawnPoints = spawnPositions;
        _interactable = interactable;
        _mediator = mediator;
    }

    public void SpawnInteractables()
    {
        foreach (Transform point in _spawnPoints)
            Spawn(point.position);
    }

    public void Spawn(Vector3 spawnPosition)
    {
        Interactable ine = Object.Instantiate(_interactable, spawnPosition, Quaternion.identity, null);
        ine.Init(_mediator);
    }
}
