using UnityEngine;
using System.Collections;

public class FlashLight : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	private bool CoolDown;
	IEnumerator Cooling() {
		yield return new WaitForSeconds (1);
		CoolDown = false;

		}
	// Update is called once per frame
	void LateUpdate () {
	if (Input.GetButton("Fire2")&CoolDown==false) {
			if (this.GetComponent<Light>().enabled) {
			this.GetComponent<Light>().enabled=false;
				CoolDown=true;
				this.audio.Play();
				StartCoroutine(Cooling());

			
	} else {
				this.GetComponent<Light>().enabled=true;
				this.audio.Play();
				CoolDown=true;
				StartCoroutine(Cooling());
}
		}
	}
}
