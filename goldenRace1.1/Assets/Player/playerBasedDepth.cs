using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerBasedDepth : MonoBehaviour {
    SpriteRenderer sprite, thisSprite;
    Collider col, playerCol;
	// Use this for initialization
	void Start () {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        playerCol = player.transform.FindChild("collider").GetComponent<Collider>();
        sprite = player.transform.FindChild("sprite").GetComponent<SpriteRenderer>();
        thisSprite = transform.FindChild("sprite").GetComponent<SpriteRenderer>();
        col = transform.FindChild("collider").GetComponent<Collider>();
    }
	
	// Update is called once per frame
	void Update () {
        if(col.bounds.Intersects(playerCol.bounds))
        {
            sprite.sortingOrder = thisSprite.sortingOrder + 1;
        }
	}
}
