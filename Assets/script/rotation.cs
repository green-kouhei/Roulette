using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation : MonoBehaviour {
    public Transform tr;
    public Rigidbody rb;        //重力
     public float coefficient;   // 空気抵抗係数
    System.Diagnostics.Stopwatch sw;


    void Start () {
        rb.velocity =new Vector3(0.0f, 15.0f * Random.value + 10.0f, 0.0f);
        //tr.Rotate(0, 2f, 0);
    }
	
	
	void Update () {
        //rotation_roulette();
       
    }

    void rotation_roulette () {
        
        //tr.Rotate(0, 2f, 0);
    }

     void FixedUpdate()
    {
        // 空気抵抗を与える
        rb.AddForce(-coefficient * rb.velocity);
    }
}
