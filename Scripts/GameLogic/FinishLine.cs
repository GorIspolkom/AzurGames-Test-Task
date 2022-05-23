using UnityEngine;

public sealed class FinishLine : MonoBehaviour
{
    [SerializeField] private UIHandler _uIHandler;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals(Settings.PlayerTag))
            _uIHandler.FinalPanel.Open();
    }
}
