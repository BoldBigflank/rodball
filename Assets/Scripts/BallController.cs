using UnityEngine;
using System.Collections;

public class BallController : MonoBehaviour {
	[SerializeField]
	float maxSpeed;
	
	[SerializeField]
	float bounciness;
	
	[SerializeField]
	float weight;
	
	Rigidbody2D rb;

	bool added;
	
	// Use this for initialization
	void Start () {
		rb = gameObject.GetComponent<Rigidbody2D>();
		added = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(ZoomToFit.current && !added){
			ZoomToFit.current.AddTarget(gameObject);
			added = true;
		}
		if(rb.velocity.magnitude > maxSpeed ){
			rb.velocity = rb.velocity.normalized * maxSpeed;
		}
	}
}
