using UnityEngine;
using System.Collections;

public class TiltAxis : MonoBehaviour {
	Rigidbody2D rb;
	// Use this for initialization
	void Start () {
		Input.gyro.enabled = true;
		rb = gameObject.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
//		transform.rotation.z = 0;

//		transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, Input.gyro.gravity.x * 90.0F);
		rb.MoveRotation(Input.gyro.gravity.x * -90.0F);

		
	}
}
