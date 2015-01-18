using UnityEngine;
using System.Collections;

public class DataControl : MonoBehaviour {

	public static DataControl instance;
	
	void Awake() {
		if (instance == null) {
			instance = this;
			DontDestroyOnLoad(gameObject);
		} else if (instance != this) {
			Destroy(gameObject);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
