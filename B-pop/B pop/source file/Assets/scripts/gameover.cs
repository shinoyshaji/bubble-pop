using UnityEngine;
using System.Collections;

public class gameover : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		
	}
	void OnGUI () {
		{
		if (GUI.Button (new Rect (Screen.width / 2 - Screen.width / 4, 200, Screen.width / 2, 40), "Retry")) {
				Application.LoadLevel (1);
			}
			
			if (GUI.Button (new Rect (Screen.width / 2 - Screen.width / 4, 260, Screen.width / 2, 40), "Menu")) {
				Application.LoadLevel (0);
			}
		}
	}
}