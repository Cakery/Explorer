using UnityEngine;
using System.Collections;

public class FlashLight : MonoBehaviour {

	//We need a cool down or it is very diffucult to even turn the light off.
	private bool CoolDown;
	IEnumerator Cooling() {
		yield return new WaitForSeconds (1);
		CoolDown = false;

		}
	// Update is called once per frame
	void LateUpdate () {
		//Here the input is checked and it is also checked to see if the CoolDown is active.
	if (Input.GetButton("Fire2")&CoolDown==false) {
			//If its not then check to see if the light is on and do everything else needed.
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
