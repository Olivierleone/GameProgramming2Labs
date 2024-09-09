using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 10f;
    private Rigidbody rb;
    private Vector3 startPosition;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        startPosition = transform.position;
    }

    // physics related operations go here 
    void FixedUpdate()
    {

        //getting the input for X and Z axis
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        //calcluating the movement direction based on the players 
        //forward and right vector

        Vector3 movement = (transform.right * moveX) +
            (transform.forward * moveZ);

        //now applying the movement to the rigidbody

        rb.AddForce (movement * moveSpeed, ForceMode.Force);


    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Goal"))
        {
            Debug.Log("You Win");
        }
        else if (other.CompareTag("Death"))
        {
            rb.position = startPosition;
        }
    }
}
