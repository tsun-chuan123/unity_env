using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardMovement : MonoBehaviour
{
    public float moveSpeed = 5f; // Adjust this to set the speed of movement
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Get input from the horizontal and vertical axes
        float horizontal = Input.GetAxis("Horizontal"); // A/D or Left/Right arrow keys
        float vertical = Input.GetAxis("Vertical"); // W/S or Up/Down arrow keys

        // Create a direction vector
        Vector3 direction = new Vector3(horizontal, 0, vertical);

        // Move the object
        transform.Translate(direction * moveSpeed * Time.deltaTime, Space.World);

    }
}
