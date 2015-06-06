using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class bubblemove : MonoBehaviour {

	//public Animation animation{ get; }
	int flg=0;

	void Start () {
		
	}
	int i,j;
	void Update () {
		if(Random.Range (-.5f,1.5f)>0)
		transform.Translate (new Vector3 (.04f, 0, 0));
		if(Random.Range (-0.5f,1.5f)<0)
		transform.Translate (new Vector3 (-.04f, 0, 0));
		if (Input.GetKeyDown ("left")) {
			j = 18;
		}
		if(j!=0)
		{
			transform.Translate (new Vector3 (-.2f, 0, 0));
			j--;
		}
		if (Input.GetKeyDown ("right")) {
						i = 18;
				}
			if(i!=0)
			{
				transform.Translate (new Vector3 (.2f, 0, 0));
				i--;
			}

	}
	void OnCollisionEnter2D(Collision2D other)
	{
	//	animation.Play("animation");
		Application.LoadLevel (2);

		
	}

}
