using UnityEngine;
using System.Collections;

public class TiltAxis : MonoBehaviour {
	Rigidbody2D rb;
	// Use this for initialization
	
	[SerializeField]
	float moveSensitivity = 15.0F;
	
	[SerializeField]
	float sideLimit = 4.0F;
	
	Vector2 touchPos;
	
	void Start () {
		
		Input.gyro.enabled = true;
		rb = gameObject.GetComponent<Rigidbody2D>();
	}
	
	void Update(){
		if(Input.touchCount > 0){
			Touch thisTouch = Input.touches[0];
			if(thisTouch.phase == TouchPhase.Began){
				touchPos = thisTouch.position;
			}
//			float touchDiff = thisTouch.position.x - touchPos.x;
			Vector3 newPosition = transform.position;
			newPosition.x += thisTouch.deltaPosition.x/moveSensitivity;
			newPosition.x = Mathf.Clamp(newPosition.x, -1.0F * GameSettings.sideLimit, GameSettings.sideLimit);
//			transform.position = newPosition;
			gameObject.GetComponent<Rigidbody2D>().MovePosition(new Vector2(newPosition.x, newPosition.y));
			
		}
	}
	
	// Update is called once per frame
	void FixedUpdate () {
	
//		transform.rotation.z = 0;

//		transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, Input.gyro.gravity.x * 90.0F);
		rb.MoveRotation(Input.gyro.gravity.x * -90.0F);
	}
	
	void OnGUI(){
		GUI.Label(new Rect(0,0,100,100), touchPos.ToString());
		
	}
}
