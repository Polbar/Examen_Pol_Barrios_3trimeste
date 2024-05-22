using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform playerTrasnform;
    public Vector2 maxCameraPosition;
    public Vector2 minCameraPosition;

    void Start()
    {
        
    }

    void Update()
    {
        Vector3 desiredPosition = playerTrasnform.position + new Vector3(0, 0, -10);

        float clampX = Mathf.Clamp(desiredPosition.x, minCameraPosition.x, maxCameraPosition.x);
        float clampY = Mathf.Clamp(desiredPosition.y, minCameraPosition.y, maxCameraPosition.y);

        Vector3 clampedPosition = new Vector3(clampX, clampY, desiredPosition.z);

        transform.position = clampedPosition;
    }
}
