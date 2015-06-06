using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class background_city: MonoBehaviour {
	void Start () {
		
	}
	void Update () {
		
		transform.Translate (new Vector3 (0, -1f* Time.deltaTime, 0));

		if(transform.position.x <(-30)) {
			Destroy (this);
		}
	}
	
}