using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ballCollision : MonoBehaviour {
    public score bob;

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("somethingsomething");
        if(collision.gameObject.name == "ball(Clone)")
        {
            Debug.Log("rawr!!");
            Destroy(gameObject);
            Destroy(collision.gameObject);
            bob.playerscore = bob.playerscore + 1 ;
            bob.playerscoreText.text = ""+bob.playerscore;
        }
    }
    // Use this for initialization
    void Start ()
    {

    }
	
	// Update is called once per frame
	void Update () {

    }
}
