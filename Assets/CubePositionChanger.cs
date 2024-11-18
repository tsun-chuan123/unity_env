using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubePositionChanger : MonoBehaviour
{
    public Vector3[] positions = new Vector3[4]; // Array for multiple target positions
    public float moveSpeed = 5f; // Speed at which the cube moves to the next position
    public float waitTime = 10f; // Time to wait at each position

    private Vector3 targetPosition; // The position the cube is currently moving towards
    private bool isWaiting = false; // Indicates if the cube is currently waiting
    private float waitTimer = 0f; // Timer to track the wait time



    // Start is called before the first frame update
    void Start()
    {
        // Ensure we have positions and set the initial random target position
        if (positions.Length > 0)
        {
            SetRandomTargetPosition();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (isWaiting)
        {
            // Increment the timer while waiting
            waitTimer += Time.deltaTime;

            // Check if the wait time has elapsed
            if (waitTimer >= waitTime)
            {
                // End waiting, reset timer, and choose a new random target position
                isWaiting = false;
                waitTimer = 0f;
                SetRandomTargetPosition();
            }
        }
        else
        {
            // Move the cube towards the target position
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);

            // Check if the cube has reached the target position
            if (Vector3.Distance(transform.position, targetPosition) < 0.1f)
            {
                // Start waiting when reaching a target position
                isWaiting = true;
            }
        }

        // Make the cube face the direction it is moving
        transform.LookAt(targetPosition);
    }
    // Function to set a random target position from the array
    void SetRandomTargetPosition()
    {
        int randomIndex = Random.Range(0, positions.Length); // Get a random index
        targetPosition = positions[randomIndex]; // Set the target position to the randomly chosen position
    }
}
