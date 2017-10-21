using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class se : MonoBehaviour {

/*
    public AudioClip audioClip;
    AudioSource audioSource;

    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
        audioSource.clip = audioClip;
    }
    */

    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            gameObject.GetComponent<AudioSource>().Play();
        }
    }


}
