using UnityEngine;

public sealed class FinishLine : MonoBehaviour
{
    [SerializeField] private UIHandler _uIHandler;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Player"))
        {
            _uIHandler.FinalPanel.Open();
        }
    }
}
