using UnityEngine;
using System.Collections;

public class zombiespawner : MonoBehaviour {

	public GameObject zombie;
	
	public int zforce = 10;
	public int zscale = 1;
	public int zdirection = 1;
	public int resettimer = 500;
	private int ztimer = 0;
	// 1 left , 2 right , 3 up ,  4 down
	public string spawnername;

	// Use this for initialization
	void Start () {
		spawnername = gameObject.name;
		spawnz();
	}
	
	// Update is called once per frame
	void Update () {
		if(!GameObject.Find(spawnername+"zombie")){
			//Debug.Log("no xombie");
			if(ztimer > resettimer){
				ztimer = 0;
				spawnz();
			}
		}
		ztimer++;
	}

	void spawnz () {

		GameObject newItem = Instantiate(zombie, transform.position, Quaternion.identity) as GameObject;
		newItem.name = gameObject.name + "zombie";

		//newItem.transform.parent = gameObject.transform;


     

	}
}



