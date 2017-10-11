using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation : MonoBehaviour {
    public Transform tr;
    System.Diagnostics.Stopwatch sw;


    void Start () {
        
    }
	
	
	void Update () {
        tr.Rotate(0, 2f, 0);
       
    }
}
