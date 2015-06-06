using UnityEngine;
using System.Collections;

public class about : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnGUI()
	{
		GUI.Label (new Rect (Screen.width / 2 - 100, 160, 200, 40), "<size=30>BUBBLE POP V tail.1.0</size>");
		GUI.Label (new Rect (Screen.width / 2 - 100, 200, 200, 40), "<size=30>Developers</size>");
		GUI.Label (new Rect (Screen.width / 2 - 200, 240, 500, 40), "<size=25>AnandhU ☺ AswiN ☺ NeeraJ ☺ ShinoY</size>");
		GUI.Label (new Rect (Screen.width / 2 - 200, 280, 500, 40), "<size=30>Assets Credits Hill climb racing -FINGERSOFT</size>");
		if (GUI.Button (new Rect (Screen.width / 2 - Screen.width / 4, Screen.height-60, Screen.width / 2, 30), "Menu")) {
			Application.LoadLevel (0);
		}
	}
}