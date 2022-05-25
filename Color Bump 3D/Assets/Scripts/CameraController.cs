using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private Rigidbody cameraRB;
    public float cameraSpeed = 3f;

    private void Awake()
    {
        cameraRB = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        CameraMovement();
    }

    private void CameraMovement()
    {
        cameraRB.MovePosition(transform.position + Vector3.forward * cameraSpeed * Time.deltaTime);
        // cameraRB.velocity = Vector3.forward * cameraSpeed * Time.deltaTime;
    }
}
