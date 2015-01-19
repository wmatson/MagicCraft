using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody2D))]
public class Attractor : MonoBehaviour {

	public GameObject target;
	public float strengthMultiplier = 1;
	public float distanceFactor = .5f;

	// Use this for initialization
	void Start () {
	
	}

	void FixedUpdate () {
		if (target == null)
			return;
		var direction = target.rigidbody2D.position -gameObject.rigidbody2D.position;
		var strength = strengthMultiplier / (direction.sqrMagnitude * distanceFactor);
		gameObject.rigidbody2D.AddForce (direction.normalized * strength);
	}
}
