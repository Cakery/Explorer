using UnityEngine;
using System.Collections;

public class LevelSwitch : MonoBehaviour {
	public int SceneID;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void OnTriggerEnter (Collider Collider) {
	if (Collider.tag == "Player") {
						if (SceneID == 0) {
								Application.LoadLevel (Application.loadedLevel + 1);
						} else {
				Application.LoadLevel (SceneID);
			}
				}
	}
}
