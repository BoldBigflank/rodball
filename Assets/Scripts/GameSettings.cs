using UnityEngine;
using System.Collections;

public class GameSettings : MonoBehaviour {
	// There's only one way to get to it
	public static GameSettings current;
	
	// The settings
	public float sideLimit = 6.0F;
	public float moveSpeed = -500.0F;
	public float slideSensitivity = 20.0F;
	
	void Awake () {
		current = this;
	}
	
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
