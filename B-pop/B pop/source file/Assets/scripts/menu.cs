using UnityEngine;
using System.Collections;

public class menu : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	
	}
	void OnGUI () {
		 {
			GUI.Box (new Rect (Screen.width / 2 - Screen.width / 4,Screen.height*(2/3), Screen.width / 2, Screen.height)," <size=21>Welcome</size>"); 
			
			if (GUI.Button (new Rect (Screen.width / 2 - Screen.width / 4,Screen.height*(1/3)+ 100, Screen.width / 2, 30), "Play")) {
				Application.LoadLevel (1);
			}
			
			if (GUI.Button (new Rect (Screen.width / 2 - Screen.width / 4, Screen.height*(1/3)+140, Screen.width / 2, 30), "About")) {
				Application.LoadLevel (3);
			}
			
			if (GUI.Button (new Rect (Screen.width / 2 - Screen.width / 4, Screen.height*(1/3)+180, Screen.width / 2, 30), "Quit")) {
				Application.Quit ();
			}
		}
}
}