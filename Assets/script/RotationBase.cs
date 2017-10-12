using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationBase : MonoBehaviour {

	
	void Start () {
        //生成オブジェクト,中心x,中心y,配置半径,配置角度
        //createCircleObject(m_object, 0,0,5.0f,20.0f);
    Rigidbody rigidbody = GetComponent<Rigidbody>();
        
       

    }
    public void Rotation() {
        if (Input.GetKeyDown(KeyCode.Space)){
            
            transform.rotation.Set(0,0,0,0);
            Rigidbody rigidbody = GetComponent<Rigidbody>();
            rigidbody.AddTorque(Vector3.up*-5000.0f);
        }
    }

}
