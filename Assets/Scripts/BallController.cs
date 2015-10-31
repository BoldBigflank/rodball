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
	
	// Use this for initialization
	void Start () {
		rb = gameObject.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		if(rb.velocity.magnitude > maxSpeed ){
			rb.velocity = rb.velocity.normalized * maxSpeed;
		}
	}
}
