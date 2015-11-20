using UnityEngine;
using System.Collections;

public class SideLimitChange : MonoBehaviour {
	[SerializeField]
	float sideLimit = 4.0F;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerEnter(Collider other){
		if(other.tag == "Player"){
			GameSettings.sideLimit = sideLimit;
		}
	}
	
	void SetSideLimit(float s){
		Debug.Log ("SetSideLimit " + s);
		sideLimit = s;
	}
}
