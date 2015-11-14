using UnityEngine;
using System.Collections;

public class GameSettings : MonoBehaviour {
	public static float sideLimit;
	

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void SetSideLimit(float s){
		Debug.Log ("SetSideLimit " + s);
		sideLimit = s;
	}
}
