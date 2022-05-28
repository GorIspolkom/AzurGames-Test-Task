using UnityEngine;

public sealed class FinishLine : MonoBehaviour
{
    [SerializeField] private UIPool _uIPool;
    [SerializeField] private Transform _targetTransfrom;

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.Equals(_targetTransfrom))
            _uIPool.FinalPanel.Open();
    }
}
