using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class FollowCamera : MonoBehaviour
{
    [SerializeField] private Vector3 _offest;
    [SerializeField] private float _smoothVelocity;
    private Transform _playerTransfrom; 

    public void Init(Transform target)
    {
        _playerTransfrom = target;
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
