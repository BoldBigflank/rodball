using UnityEngine;
using System.Collections;

public class TiltInput : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Input.gyro.enabled = true;
	}
	
	// Update is called once per frame
	void Update () {
		transform.rotation = Input.gyro.attitude;
		
		Quaternion a = Quaternion.FromToRotation(Vector3.down, Input.gyro.gravity);
//		Vector3 grav = Input.gyro.gravity;
//		transform.LookAt(new Vector3(grav.x, grav.z, grav.y));// = Quaternion.Euler( -180.0F * Input.gyro.gravity ) ;
		transform.rotation = Input.gyro.attitude;
	}
	
	void OnGUI(){
		GUI.Label(new Rect(0,0,100,100), Input.gyro.attitude.ToString());
		GUI.Label(new Rect(0,100,100,100), Input.gyro.gravity.ToString());
	
	}
}
