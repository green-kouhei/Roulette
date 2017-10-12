using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteOperation : MonoBehaviour {

	public GameObject rotationBase;
	public GameObject ball;

	void Update () {
		RotationBase rb = rotationBase.GetComponent<RotationBase>();
		ball_add_force baf = ball.GetComponent<ball_add_force>();

        if (Input.GetKeyDown(KeyCode.Space)){
           rb.Rotation();
		   baf.add_force();

        }
	}

}
