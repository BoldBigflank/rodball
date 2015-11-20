using UnityEngine;
using System.Collections;

public class Reset : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnCollisionEnter2D(Collision2D coll){
		Debug.Log ("collided!");
		if(coll.gameObject.tag == "Ball"){
			Vector3 newPosition = coll.gameObject.transform.position;
			newPosition.y += 10;
			newPosition.x = 0;
			
			coll.gameObject.transform.position = newPosition;
		}
	}
}
