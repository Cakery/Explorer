using UnityEngine;
using System.Collections;

public class LevelSwitch : MonoBehaviour {
	public int SceneID;

	public bool FadeIn;

	public GUITexture GTexture;

	private Color Alpha;
		
	private bool FadedIn;
	private bool Collided;
	// Use this for initialization
	void Start () {
		Alpha = GTexture.color;
	}
	IEnumerator Wait() {
		yield return new WaitForSeconds (3F);
		if (SceneID == 0) {
			Application.LoadLevel (Application.loadedLevel + 1);
		} else {
			Application.LoadLevel (SceneID);
		}
	}

	IEnumerator FadingIn() {

		GTexture.enabled = true;
		while (Alpha.a<1) {
			//print(Alpha.a);
			Alpha.a+=0.01F*Time.deltaTime*1.1F;
			GTexture.color = Alpha;
			yield return new WaitForSeconds(0.1F);
		}
		FadedIn = true;
	}
	// Update is called once per frame
	void OnTriggerEnter (Collider Collider) {
	if (Collider.tag == "Player") {
			Collided=true;
				
	}
}

void Update() {
		if (Collided) {
			StartCoroutine(FadingIn());
			StartCoroutine(Wait());
		}
}
}