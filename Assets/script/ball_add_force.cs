using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball_add_force : MonoBehaviour {

    public Rigidbody rb;        //重力
    public float coefficient;   // 空気抵抗係数
    public float speed = 100000;
    public GameObject ball;

    public void add_force(){
            
            GameObject newball = Instantiate(ball,new Vector3(10.7f,2.3f,-2.3f),Quaternion.identity);
			Vector3 force = newball.transform.forward * speed;
            newball.GetComponent<Rigidbody>().AddForce(force* (Random.value*0.3f+0.7f));


        // Destroy(ball);
        // rb = GetComponent<Rigidbody>();
        //    // rb.velocity = new Vector3( -10.0f, 0.0f, 15.0f * Random.value + 10.0f);
        //     Debug.Log(rb.velocity);
           
    }


    void FixedUpdate()
    {
        // 空気抵抗を与える
        rb.AddForce(-coefficient * rb.velocity);
    }
}
