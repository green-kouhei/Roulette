using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation : MonoBehaviour {
    public Transform tr;
    System.Diagnostics.Stopwatch sw;


    void Start () {
        
    }
	
	
	void Update () {
        rotation_roulette();
       
    }

    void rotation_roulette () {
        tr.Rotate(0, 2f, 0);
    }
}
