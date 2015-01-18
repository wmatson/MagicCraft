using UnityEngine;
using System.Collections;

public class Controller : MonoBehaviour {

	public GameObject target;
	public float force = 1;


	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		var movement = new Vector2 (Input.GetAxis ("Horizontal"), Input.GetAxis ("Vertical"));
		target.rigidbody2D.AddForce (force * movement * Time.fixedDeltaTime);
	}

	void Update() {
		var attack = new Vector2 (Input.GetAxis ("RightHorizontal"), Input.GetAxis ("RightVertical"));
	}

}
