using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerBasedDepth : MonoBehaviour {
    SpriteRenderer sprite;
    bool behind = false;
	// Use this for initialization
	void Start () {
        sprite = transform.FindChild("sprite").GetComponent<SpriteRenderer>();
    }
	
	// Update is called once per frame
	void Update () {

	}
    void OnTriggerStay(Collider other)
    {
        if(other.gameObject.name == "backwallCollider")
        {
            behind = true;
            sprite.sortingOrder = other.transform.parent.transform.FindChild("sprite").GetComponent<SpriteRenderer>().sortingOrder - 10;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "backwallCollider")
        {
            behind = false;
            sprite.sortingOrder = other.transform.parent.transform.FindChild("sprite").GetComponent<SpriteRenderer>().sortingOrder - 10;
        }
    }
    void OnCollisionEnter(Collision other)
    {
        if (!behind)
        {
            sprite.sortingOrder = other.transform.parent.transform.FindChild("sprite").GetComponent<SpriteRenderer>().sortingOrder + 10;
        }
    }
}
