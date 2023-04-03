using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killafterx : MonoBehaviour {

    float seconds ; //timer
    public float x ; // x
	// Use this for initialization
	void Start () {
        seconds = 0;
	}
	
	// Update is called once per frame
	void Update () {
        seconds = seconds + Time.deltaTime;
        if(seconds > x)
        {
            Destroy(gameObject);
        }
	}
}
