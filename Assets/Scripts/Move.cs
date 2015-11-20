using UnityEngine;
using System.Collections;

[RequireComponent(typeof (Rigidbody2D))]
public class Move : MonoBehaviour {

	[SerializeField]
	float moveSpeed;
	
	Rigidbody2D moveObject;

	bool enabled;
	
	// Use this for initialization
	void Start () {
		enabled = false;
	}
	
	void OnEnable(){
		moveObject = GetComponent<Rigidbody2D>();
	}
	
	void OnDisable(){
		moveObject.velocity = Vector2.zero;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.anyKeyDown){
			enabled = true;
		}

		if(enabled){
			Vector2 moveAmount = Vector2.up * Time.deltaTime * moveSpeed;
			moveObject.velocity = moveAmount;
		}
//		if(Input.touchCount == 0 ){ 
//			moveObject.velocity = moveAmount;
//		} else {
//			moveObject.velocity = -moveAmount;
//		}
	}
}
