﻿using UnityEngine;

public class CamFollow : MonoBehaviour
{
    public Transform target;

    public float smoothSpeed;
    public Vector3 offset; 

    private void LateUpdate()
    {
        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;
    }

}

