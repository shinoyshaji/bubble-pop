using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class buildingmove: MonoBehaviour  {
	 float speed = 2.5f;
	 float horizontalDirection = -1.2f;
	float fl=0;
	int ti=0;
	void Start () {
	
	}
	void Update () {
		ti++;
		if (ti>=1000)
		{
			speed=speed+2f;
			ti=0;
		}

			transform.Translate (new Vector3 (0,speed* horizontalDirection * Time.deltaTime, 0));

				if(transform.position.y <-25f) {
						transform.Translate (new Vector4 (0, 40f, 0));
				}
		}


}