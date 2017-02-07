using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour {
    [SerializeField]
    Transform following;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 newPos = new Vector3(following.position.x, 60, following.position.z);
        transform.position = newPos;
	}
}
