using UnityEngine;
using System.Collections;

public class GrabBall : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}
	
	void OnCollisionEnter2D(Collision2D coll){
		if(coll.gameObject.tag == "Ball"){
			if(Input.touchCount > 0){
				// We don't even care where the touch is
				// Grab the ball
				coll.gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
				
			}
		}
	}
}
