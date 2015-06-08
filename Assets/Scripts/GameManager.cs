using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
	public Camera Camera;
	// Use this for initialization
	void Start () {
		//Game setup
		Screen.showCursor = false;

		//Load CFG and apply values
 string[] File=System.IO.File.ReadAllLines ("settings.cfg");
		print(File[0]);
		foreach (string I in File) {
			string[] Values=I.Split('=');

			if (Values[0]=="FOV") {
				Camera.fieldOfView=int.Parse(Values[1]);
			}
			if (Values[0]=="MouseSens") {
				MouseLook.sensitivityX=int.Parse(Values[1]);
				MouseLook.sensitivityY=int.Parse(Values[1]);
			}
				}
	}
	
	// Update is called once per frame
	void Update () {
	if (Input.GetButton ("Screenshot")) {
			Application.CaptureScreenshot("img.png");
				}
	}
}

