using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Background: MonoBehaviour {
	 float speed = .015f;
	 float horizontalDirection ;
	public GUIText score;
	int flg=0;
	 protected int time=0;

	void Start () {
		
	}
	void Update () {

		flg++;
		if (flg >=100) {
						time++;
			flg=0;
		}
		score.text = "score:" + time;

		if(transform.position.x >12) {
			horizontalDirection=-1;
		}
		if(transform.position.x <(-23)) {
			horizontalDirection=1;
		}
		transform.Translate (new Vector3 (speed * horizontalDirection,0, 0));

	}



}