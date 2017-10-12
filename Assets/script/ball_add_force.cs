using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball_add_force : MonoBehaviour {

    public Rigidbody rb;        //重力
    public float coefficient;   // 空気抵抗係数

    public GameObject ball;

    void Start () {
        Instantiate(ball,new Vector3(10.7f,2.3f,-2.3f),Quaternion.identity);
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-10.0f, 0.0f, 15.0f * Random.value + 10.0f);
        Debug.Log(rb.velocity);
    }
	
	void Update () {
        // if (Input.GetKeyDown(KeyCode.Space)){
        //     Destroy(this);
        //     Instantiate(ball,new Vector3(10.7f,2.3f,-2.3f),Quaternion.identity);
        //     rb.velocity = new Vector3( -10.0f, 0.0f, 15.0f * Random.value + 10.0f);
        //     Debug.Log(rb.velocity);
        //     this.transform.position = new Vector3(11.45f, 12.60f, 0.0f);
        // }

    }

    public void add_force(){
            Destroy(this);
            Instantiate(ball,new Vector3(10.7f,2.3f,-2.3f),Quaternion.identity);
            rb.velocity = new Vector3( -10.0f, 0.0f, 15.0f * Random.value + 10.0f);
            Debug.Log(rb.velocity);
            this.transform.position = new Vector3(11.45f, 12.60f, 0.0f);
    }


    void FixedUpdate()
    {
        // 空気抵抗を与える
        rb.AddForce(-coefficient * rb.velocity);
    }
}
