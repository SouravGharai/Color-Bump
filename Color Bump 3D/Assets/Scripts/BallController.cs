using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public float ballSpeed = 150f;
    public float speedSmoothness;
    public float wallDistance = 5f;
    public float minCamDistance = 3f;

    private Rigidbody ballRB;
    private Camera mainCamera;

    private void Awake()
    {
        ballRB = GetComponent<Rigidbody>();
        mainCamera = FindObjectOfType<CameraController>().GetComponent<Camera>();
    }

    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            HorizontalMove();
        }

        ForwardMovement();

    }

    private void HorizontalMove()
    {
        Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, 100))
        {
            transform.position = Vector3.Lerp(transform.position, new Vector3(hit.point.x, transform.position.y, hit.point.z), speedSmoothness * Time.deltaTime);
        }
    }

    private void ForwardMovement()
    {
        //ballRB.velocity = Vector3.forward * ballSpeed * Time.fixedDeltaTime;
        ballRB.MovePosition(transform.position + Vector3.forward * ballSpeed * Time.deltaTime);
    }

    private void LateUpdate()
    {
        //Get the 3d Position Of ball
        Vector3 ballPosition = transform.position;

        //Clamping
        if (transform.position.x < -wallDistance)
        {
            ballPosition.x = -wallDistance;
        }
        else if (transform.position.x > wallDistance)
        {
            ballPosition.x = wallDistance;
        }

        //Restrict with camera position
        if (transform.position.z < mainCamera.transform.position.z + minCamDistance)
        {
            ballPosition.z = mainCamera.transform.position.z + minCamDistance;
        }

        transform.position = ballPosition;
    }
}
