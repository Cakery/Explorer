using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {
	float FOV = 0.0F;
	float MouseSens=0F;
	// Use this for initialization
	void Start () {
				string[] File = System.IO.File.ReadAllLines ("settings.cfg");
				if (System.IO.File.Exists ("settings.cfg")) {
						foreach (string I in File) {
								string[] Values = I.Split ('=');
				
								if (Values [0] == "FOV") {
										FOV = float.Parse (Values [1]);
								}
								if (Values [0] == "MouseSens") {
										MouseSens = float.Parse (Values [1]);
								}
						}


				} else {

						System.IO.File.WriteAllText ("settings.cfg", "FOV=" + "60" + "\nMouseSens=" + 15);
				}
		}

	private bool Main=true;
	void Settings() {

		Main = false;
		GUI.Box(new Rect(Screen.width/2-100,Screen.height/2-100,400,200), "Settings");
		FOV=GUI.HorizontalSlider (new Rect (Screen.width/2,Screen.height/2, 180, 20), FOV, 60F,120F);
		GUI.Label (new Rect(Screen.width/2+200,Screen.height/2, 100, 100), Mathf.Floor(FOV).ToString());

		MouseSens=GUI.HorizontalSlider (new Rect (Screen.width/2,Screen.height/2+50, 180, 20), MouseSens, 1F,30F);
		GUI.Label (new Rect(Screen.width/2+200,Screen.height/2+50, 100, 100), Mathf.Floor(MouseSens).ToString());

		if (GUI.Button (new Rect (20, 40, 80, 20), "Save")) {

			System.IO.File.WriteAllText("settings.cfg","FOV="+Mathf.Floor(FOV)+"\nMouseSens="+Mathf.Floor(MouseSens));
		}


		if (GUI.Button (new Rect (20, 60, 180, 20), "Close (Without saving)")) {
			Main=true;
		}
	}



	void OnGUI () {
		if (Main == true) {
						// Make a background box
						GUI.Box (new Rect (10, 10, 100, 90), "Simple Menu");
		
						// Make the first button. If it is pressed, Application.Loadlevel (1) will be executed
						if (GUI.Button (new Rect (20, 40, 80, 20), "Start")) {
								Application.LoadLevel (1);
						}
		
						// Make the second button.
						if (GUI.Button (new Rect (20, 70, 80, 20), "Settings")) {
								Settings ();
						}
				} else {
			Settings();
	}
}
}
