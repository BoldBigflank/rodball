using UnityEngine;
using System.Collections;

public class PaddleController : MonoBehaviour {
	[SerializeField]
	float moveSpeed;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.touchCount == 0 ){
			gameObject.GetComponent<Rigidbody2D>().MovePosition((Vector2)transform.position + Vector2.up * Time.deltaTime * moveSpeed);
		}
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
