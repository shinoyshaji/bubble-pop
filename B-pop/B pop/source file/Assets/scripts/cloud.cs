using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class cloud: MonoBehaviour {
	public float speed = 1f;
	public float horizontalDirection = -1;
	void Start () {
		
	}
	void Update () {
		
		
		transform.Translate (new Vector3 ( speed * horizontalDirection * Time.deltaTime,0, 0));
		
		if(transform.position.x <-15f) {
			transform.Translate (new Vector4 (0, 40f, 0));
		}
	}
	
}