using UnityEngine;
using Zenject;

public struct FollowCameraData
{
    public Transform playerTransfrom;
    public Vector3 offset;
    public float smoothVelocity;

    public FollowCameraData(Transform target, Vector3 offset, float smoothVelocity)
    {
        playerTransfrom = target;
        this.offset = offset;
        this.smoothVelocity = smoothVelocity;
    }
}

public sealed class FollowCamera : MonoBehaviour
{
    private FollowCameraData _followCameraData;

    [Inject]
    public void Init(FollowCameraData followCameraData)
    {
        _followCameraData = followCameraData;
    }

    private void LateUpdate()
    {
        MoveCamera();
    }
    
    private void MoveCamera()
    {
        Vector3 desiredPos = _followCameraData.playerTransfrom.position - _followCameraData.offset;
        Vector3 smoothPos = Vector3.Lerp(transform.position, desiredPos, _followCameraData.smoothVelocity);
        transform.position = smoothPos;
    }
}
