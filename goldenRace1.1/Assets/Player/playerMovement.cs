using UnityEngine;
using System.Collections;

public class playerMovement : MonoBehaviour {
    public float thrust = 5;
    public Rigidbody rb;
    public float turnRate = 50;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(transform.forward * thrust);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(-transform.forward * thrust);
        }

        if (Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.down * Time.deltaTime * turnRate);
        }
        else if (!Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up * Time.deltaTime * turnRate);
        }
    }
}
