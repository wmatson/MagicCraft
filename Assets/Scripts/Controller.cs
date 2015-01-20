using UnityEngine;
using System.Collections;

public class Controller : MonoBehaviour {

	public GameObject target;
	public float force = 250;

	private GameObject melee;

	// Use this for initialization
	void Start () {
		foreach (Transform child in target.transform) {
			if(child.name == "Melee") {
				melee = child.gameObject;
			}
		}
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		var movement = new Vector2 (Input.GetAxis ("Horizontal"), Input.GetAxis ("Vertical"));
		target.rigidbody2D.AddForce (force * movement * Time.fixedDeltaTime);
	}

	void Update() {
		var attack = new Vector2 (-Input.GetAxis ("RightHorizontal"), Input.GetAxis ("RightVertical"));
		if (attack.sqrMagnitude > 0) {
			target.transform.rotation = Quaternion.AngleAxis (Mathf.Atan2 (attack.y, attack.x) * Mathf.Rad2Deg, Vector3.forward);
			if (!melee.activeSelf) {
				melee.SetActive(true);
			}
		} else {
			if(melee.activeSelf) {
				melee.SetActive(false);
			}
		}
	}

}
