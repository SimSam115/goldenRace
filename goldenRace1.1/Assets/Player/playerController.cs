using UnityEngine;
using System.Collections;

public class playerController : MonoBehaviour{

    Rigidbody rb;
    [SerializeField]
    int speed = 10;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 vel = new Vector3(moveHorizontal * Time.deltaTime * speed, 0.0f, moveVertical * Time.deltaTime * speed);
        rb.velocity = vel;
    }
}
