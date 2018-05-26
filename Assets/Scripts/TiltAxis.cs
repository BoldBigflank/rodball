using UnityEngine;
using System.Collections;

public class TiltAxis : MonoBehaviour {
	Rigidbody2D rb;
	// Use this for initialization
	
	Vector2 touchPos;
	
	void Start () {
		
		Input.gyro.enabled = true;
		rb = gameObject.GetComponent<Rigidbody2D>();
		rb.centerOfMass = new Vector2(-20.0F, 0.0F);
		rb.
	}
	
	void Update(){
		if(Input.touchCount > 0){
			Touch thisTouch = Input.touches[0];
//			touchPos = thisTouch.position; // For GUI Debugging
//			touchPos = thisTouch.deltaPosition; // For GUI Debugging

//			float touchDiff = thisTouch.position.x - touchPos.x;
			Vector3 newPosition = transform.position;
			newPosition.x += thisTouch.deltaPosition.x/GameSettings.current.slideSensitivity;
			newPosition.x = Mathf.Clamp(newPosition.x, -1.0F * GameSettings.current.sideLimit, GameSettings.current.sideLimit);
			touchPos = newPosition - transform.position; // For GUI Debugging
			transform.position = newPosition;
			gameObject.GetComponent<Rigidbody2D>().MovePosition(new Vector2(newPosition.x, newPosition.y));
		}
	}
	
	// Update is called once per frame
	void FixedUpdate () {
	
//		transform.rotation.z = 0;

//		transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, Input.gyro.gravity.x * 90.0F);

		// Apple TV/iOS Remote
//		rb.MoveRotation(Input.gyro.gravity.x * -90.0F);

		rb.MoveRotation(Input.GetAxis("Horizontal")*-90.0F);
	}
	
	void OnGUI(){
		GUI.Label(new Rect(0,0,100,100), touchPos.ToString());
		
	}
}
