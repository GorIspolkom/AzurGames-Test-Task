using UnityEngine;

public sealed class InteractableMediator : MonoBehaviour
{
    [SerializeField] private Spawner _effectSpawner;
    private UIHandler _uIHandler;
    private PlayerData _playerData;

    public void Init(PlayerData playerData, UIHandler uIHandler) 
    { 
        _playerData = playerData;
        _uIHandler = uIHandler;
    }

    public void Notify(Interactable interactable)
    {
        _playerData.AddCoins(interactable.interactableCoast);
        _uIHandler.CoinsCounter.OnNotify(_playerData.CoinsCount);
        _effectSpawner.Spawn(interactable.gameObject.transform.position);
    }
    private void Start()
    {
        _uIHandler.CoinsCounter.OnNotify(_playerData.CoinsCount);
    }
}
