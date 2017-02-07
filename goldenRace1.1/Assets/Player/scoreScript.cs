using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scoreScript : MonoBehaviour {
    
    int score;
    void Start () {
        score = 0;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    public int getScore()
    {
        return score;
    }
    public void setScore(int score_)
    {
        score = score_;
    }
}
