using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetCamera : MonoBehaviour {
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        GameObject ball = GameObject.Find("golden_ball" + "(Clone)");
        if(ball != null)
            transform.LookAt(ball.transform);
    }
}
