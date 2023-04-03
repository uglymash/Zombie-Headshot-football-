using UnityEngine;

using System.Collections;

public class zhf_touchfollow : MonoBehaviour {
	public Vector3 victor;
	//public GameObject cube;
	//public Transform cube = this.gameObject.GetComponent<RectTransform>().transform;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0)){
			victor = new Vector3(Input.mousePosition.x,Input.mousePosition.y,0);
			//cube.transform = forward;
			//RectTransform(Input.mousePosition.x,Input.mousePosition.y,0);
		}
	}
}
