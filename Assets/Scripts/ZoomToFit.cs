using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ZoomToFit : MonoBehaviour {
	[SerializeField]
	GameObject[] focusTargets;
	
	[SerializeField]
	float minHeight;
	
	[SerializeField]
	float topBuffer;
	
	[SerializeField]
	float bottomBuffer;
	
	[SerializeField]
	float damping;
	
	[SerializeField]
	Camera cam;
	
	float screenAngle;
	
	// Use this for initialization
	void Start () {
		screenAngle = Mathf.Atan2(Screen.width, Screen.height);
	}
	
	// Update is called once per frame
	void Update () {
		if(focusTargets.Length > 0) SetCameraPosition();
	}
	
	void SetCameraPosition(){
		float lowest = Mathf.Infinity;
		float highest = Mathf.NegativeInfinity;
		foreach(GameObject o in focusTargets){
			//			Debug.Log(o.tag + " " + o.transform.position);
			if(o.transform.position.y > highest)
				highest = o.transform.position.y;
			if(o.transform.position.y < lowest)
				lowest = o.transform.position.y;
		}
		if(lowest == Mathf.Infinity || highest == Mathf.NegativeInfinity) return;
		
		// Position
		float midpoint = ((highest + topBuffer) + (lowest - bottomBuffer)) / 2.0F; // midpoint of the two screen edges
		Vector3 newPosition = new Vector3(transform.position.x, midpoint, transform.position.z);
		transform.position = Vector3.Lerp(transform.position, newPosition, Time.deltaTime * damping);
		
		// Camera Size
		float camHeight = (highest + topBuffer) - (lowest - bottomBuffer);
		if(camHeight < minHeight) camHeight = minHeight;
		cam.orthographicSize = camHeight/2.0F;
	}
}
