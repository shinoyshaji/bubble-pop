using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class left: MonoBehaviour {

	void Start () {
		
	}
	void Update () {
		
		Input.GetKeyDown ("right");
		transform.Translate (new Vector3 (5,0, 0));
		
	}
	
	
	
}