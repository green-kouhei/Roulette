using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationBase : MonoBehaviour {

	// Use this for initialization
	void Start () {
        //生成オブジェクト,中心x,中心y,配置半径,配置角度
        //createCircleObject(m_object, 0,0,5.0f,20.0f);

        Rigidbody rigidbody = GetComponent<Rigidbody>();
        rigidbody.AddTorque(Vector3.up*5000.0f);

    }

}
