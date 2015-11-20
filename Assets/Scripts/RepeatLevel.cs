using UnityEngine;
using System.Collections;

public class RepeatLevel : MonoBehaviour {
	Vector3 startPosition;
	
	// Use this for initialization
	void Start () {
		startPosition = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if(transform.position.y < 0.0F){
		transform.position = startPosition;
		}
	}
}
