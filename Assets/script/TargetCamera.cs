using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetCamera : MonoBehaviour {
    Vector3 mBasePosition;
    // Use this for initialization
	void Start () {
        mBasePosition = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        GameObject ball = GameObject.Find("golden_ball" + "(Clone)");

        if (ball != null)
        {
            Vector3 vect = (ball.transform.position - mBasePosition).normalized;
            transform.position = mBasePosition + vect * 1.0f;
            transform.LookAt(ball.transform);
        }
    }
}
