using UnityEngine;
using System.Collections;

[RequireComponent(typeof (Rigidbody2D))]
public class Move : MonoBehaviour {

	Rigidbody2D moveObject;
	
	// Use this for initialization
	void Start () {
		Time.timeScale = 0.0F;
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
			Time.timeScale = 1.0F;
		}

		Vector2 moveAmount = Vector2.up * Time.deltaTime * GameSettings.current.moveSpeed;
		moveObject.velocity = moveAmount;
		
//		if(Input.touchCount == 0 ){ 
//			moveObject.velocity = moveAmount;
//		} else {
//			moveObject.velocity = -moveAmount;
//		}
	}
}
