using UnityEngine;
using Zenject;

public sealed class FollowCamera : MonoBehaviour
{ 
    private Transform _playerTransfrom;
    private Vector3 _offest;
    private float _smoothVelocity;
   
    [Inject]
    public void Init(Transform target, Vector3 offset, float smoothVelocity)
    {
        _playerTransfrom = target;
        _offest = offset;
        _smoothVelocity = smoothVelocity;
    }

    private void LateUpdate()
    {
        MoveCamera();
    }
    
    private void MoveCamera()
    {
        Vector3 desiredPos = _playerTransfrom.position - _offest;
        Vector3 smoothPos = Vector3.Lerp(transform.position, desiredPos, _smoothVelocity);
        transform.position = smoothPos;
    }
}
