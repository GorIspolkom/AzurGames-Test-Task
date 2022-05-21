using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine;

public class CoinsCounter : MonoBehaviour
{
    [SerializeField] private TMP_Text _coinsCountText;

    public void OnNotify(double coinsCount) => Notify?.Invoke(coinsCount);

    private event TextUpdate Notify;
    private delegate void TextUpdate(double coinsCount);

    private void CoinsTextUpdate(double coinsCount)
    {
        _coinsCountText.text = coinsCount.ToString();
    }

    private void Awake()
    {
        Notify += CoinsTextUpdate;
    }
}
