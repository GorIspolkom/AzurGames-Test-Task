using TMPro;
using UnityEngine;

public sealed class CoinsCounter : MonoBehaviour
{
    [SerializeField] private TMP_Text _coinsCountText;

    public void CoinsTextUpdate(double coinsCount)
    {
        _coinsCountText.text = coinsCount.ToString();
    }

    private void Awake()
    {
        CoinsTextUpdate(0);
    }
}
