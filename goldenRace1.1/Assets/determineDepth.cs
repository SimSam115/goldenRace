using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class determineDepth : MonoBehaviour {
    SpriteRenderer sprite;
    // Use this for initialization
    void Start()
    {
        sprite = transform.FindChild("sprite").GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update () {
        sprite.sortingOrder = -(int)transform.position.z + (int)transform.position.x;
	}
}
