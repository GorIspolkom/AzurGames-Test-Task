using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] private Transform playerTransfrom;
    [SerializeField] private Vector3 offest;
    [SerializeField] private float smoothVelocity;

    private void LateUpdate()
    {
        Vector3 desiredPos = playerTransfrom.position - offest;
        Vector3 smoothPos = Vector3.Lerp(transform.position, desiredPos, smoothVelocity);
        transform.position = smoothPos;
    }
}
