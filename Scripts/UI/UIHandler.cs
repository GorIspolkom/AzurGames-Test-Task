using UnityEngine;

public sealed class UIHandler : MonoBehaviour
{
    [SerializeField] private CoinsCounter _coinsCounter;
    [SerializeField] private FinalPanel _finalPanel;

    public void Init(LevelManager levelManager)
    {
        _finalPanel.InitPanel(levelManager);
    }

    public CoinsCounter CoinsCounter { get { return _coinsCounter; } }
    public FinalPanel FinalPanel { get { return _finalPanel; } }
}
