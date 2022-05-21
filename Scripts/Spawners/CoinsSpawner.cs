using UnityEngine;

public sealed class CoinsSpawner : Spawner
{
    [SerializeField] private Transform[] _spawnPoints;
    [SerializeField] private Interactable _interactable;
    [SerializeField] private InteractableMediator _mediator;

    private void Awake()
    {
        SpawnInteractables();
    }

    private void SpawnInteractables()
    {
        foreach (Transform point in _spawnPoints)
            Spawn(point.position);
    }

    public override void Spawn(Vector3 spawnPosition)
    {
        Interactable ine = Instantiate(_interactable, spawnPosition, Quaternion.identity, null);
        ine.Init(_mediator);
    }
}
