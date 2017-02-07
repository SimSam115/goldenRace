using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerBasedDepth : MonoBehaviour {
    Transform playerPos;
    SpriteRenderer sprite;
    Collider col, playerCol;
	// Use this for initialization
	void Start () {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        playerPos = player.transform;
        playerCol = player.transform.FindChild("collider").GetComponent<Collider>();
        sprite = transform.FindChild("sprite").GetComponent<SpriteRenderer>();
        col = transform.FindChild("depthCollider").GetComponent<Collider>();
    }
	
	// Update is called once per frame
	void Update () {
        if(col.bounds.Intersects(playerCol.bounds))
        {
            sprite.sortingOrder = -10;
            Debug.Log("R");
        }
        else
        {
            sprite.sortingOrder = 10;
        }
	}
}
