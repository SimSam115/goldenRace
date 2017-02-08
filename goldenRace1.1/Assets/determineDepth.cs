using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class determineDepth : MonoBehaviour
{
    [SerializeField]
    float zOff = 100;
    float xOff = 10;
    SpriteRenderer sprite;

    // Use this for initialization
    void Start()
    {
        sprite = transform.FindChild("sprite").GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update () {
        sprite.sortingOrder = (int)(-transform.position.z * zOff + transform.position.x * xOff);
	}
}
