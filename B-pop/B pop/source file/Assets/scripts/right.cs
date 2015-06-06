using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class right: MonoBehaviour {
	
	void Start () {
		
	}
	void Update () {
		
		Input.GetKeyDown ("left");
		transform.Translate (new Vector3 (-5,0, 0));
		
	}
	
	
	
}