using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scoreRewarder : MonoBehaviour {
    
    scoreScript score;
    bool hasScore = false;
    [SerializeField]
    int amount = 10;
    // Use this for initialization
    void Start () {
        score = GameObject.FindGameObjectWithTag("Player").GetComponent<scoreScript>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnCollisionEnter(Collision c)
    {
        if(c.gameObject.tag == "Player" && !hasScore)
        {
            hasScore = true;
            score.setScore(score.getScore() + amount);
        }

    }
}
