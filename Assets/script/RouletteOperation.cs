using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteOperation : MonoBehaviour {
    public float speed = 1500.0f;
    public GameObject rotationBase;
	public GameObject ball;

	void Update () {

        if (Input.GetKeyDown(KeyCode.Space)){
            //ルーレット回転処理
            Rigidbody rigidbody = rotationBase.GetComponent<Rigidbody>();
            rigidbody.velocity = Vector3.zero;
            rigidbody.AddTorque(Vector3.up * 4000.0f);

            //前回のボールを削除
            GameObject ballClone = GameObject.Find("golden_ball" + "(Clone)");
            if(ballClone != null)
            {
                Destroy(ballClone);
            }
            //ボールを打ち出す
            add_force();
        
        }
	}



    public void add_force()
    {
        GameObject newball = Instantiate(ball, new Vector3(9.7f, 3.0f, -0.3f),ball.transform.rotation);
        newball.SetActive(true);
        Vector3 force = newball.transform.forward.normalized * (speed * (Random.value * 0.1f + 0.9f));
        newball.GetComponent<Rigidbody>().AddForce(force);
        //newball.GetComponent<Rigidbody>().AddTorque(-force);

    }

}
