using UnityEngine;
using System.Collections;

public class SideLimitChange : MonoBehaviour {
	float newSides;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other){
		Debug.Log ("Trigger Entered " + other.tag);
		// If the player got to the trigger, set the sides.
		if (other.tag == "Player"){
			Debug.Log ("Now setting the sideLimit and disabling");
			GameSettings.current.sideLimit = newSides;
			gameObject.SetActive(false);
		}
		
	}

	void SetSideLimit(string s){
		Debug.Log ("SetSideLimit was called by SideLimitChange " + s);
		newSides = float.Parse (s); // Get the number from the map file
		
	}
}
