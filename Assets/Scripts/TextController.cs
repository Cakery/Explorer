using UnityEngine;
using System.Collections;

public class TextController : MonoBehaviour {
	Color Alpha;

	bool FadedIn;
	bool FadedOut;
	// Use this for initialization
	void Start () {
		Alpha= GetComponent<GUIText>().material.color;
		Alpha.a = 0.0F;
		GetComponent<GUIText>().material.color = Alpha;

		//StartCoroutine (FadeIn ());
	}

	IEnumerator FadeIn() {
		while (Alpha.a<1) {
			//print(Alpha.a);
			Alpha.a+=0.01F*Time.deltaTime*1.1F;
			GetComponent<GUIText>().material.color = Alpha;
			yield return new WaitForSeconds(0.1F);
		}
		FadedIn = true;
	}


	IEnumerator FadeOut() {
		while (Alpha.a>0) {

			Alpha.a-=0.01F*Time.deltaTime*1.1F;
			GetComponent<GUIText>().material.color = Alpha;
			//print(Alpha.a);
			yield return new WaitForSeconds(0.1F);

		}
		FadedOut = true;
	}
	// Update is called once per frame
	void Update () {
				if (!FadedIn) {
						StartCoroutine (FadeIn ());
				} else {
						StartCoroutine (FadeOut ());
			if (FadedOut) {
				this.gameObject.SetActive(false);
			}
				}
		}
}
