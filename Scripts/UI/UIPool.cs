using UnityEngine;
using Zenject;

public sealed class UIPool : MonoBehaviour
{
    [SerializeField] private CoinsCounter _coinsCounter;
    [SerializeField] private FinalPanel _finalPanel;

    [Inject]
    public void Init(LevelLoader levelLoader)
    {
        _finalPanel.InitPanel(levelLoader);
    }

    public CoinsCounter CoinsCounter { get { return _coinsCounter; } }
    public FinalPanel FinalPanel { get { return _finalPanel; } }
}
