using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapController : MonoBehaviour
{
    public float rotationSpeed = 100f;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        Quaternion deltaRotation = Quaternion.Euler(0, rotationSpeed *
            Time.fixedDeltaTime, 0);

        rb.MoveRotation(rb.rotation * deltaRotation);
        
    }
}
