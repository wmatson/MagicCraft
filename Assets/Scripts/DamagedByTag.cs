using UnityEngine;
using System.Collections;

public class DamagedByTag : MonoBehaviour {

	public string damageTag = "PlayerAttack";

	void Start () {
	
	}

	void OnTriggerEnter2D (Collider2D collision) {
		if(collision.gameObject.tag == damageTag)
			Destroy (gameObject);
	}
}
