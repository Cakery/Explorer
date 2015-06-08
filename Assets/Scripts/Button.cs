using UnityEngine;
using System.Collections;

public class Button : MonoBehaviour {
	//This is for auto closing. Closes the door after 5 seconds.
	IEnumerator Close() {
		yield return new WaitForSeconds(5);
		door.Close ();
	}

	//We decalre an offset for the button so you don't need to jump ontop of it to use it. We also declare the Door object so we can access its functions.
	Vector3 Offset = new Vector3 (0, 20, 0);
	public Door door;

	// Update is called once per frame
	void Update () {
		//Check if the player is pressing the correct button and standing in the right place.
		if (Input.GetButton ("Fire1") & Physics.Raycast (transform.position, transform.TransformDirection (Vector3.forward - Offset), 2)) {
			//If the door object is null, it will throw an error.			
			if (door != null) {
				Debug.Log("Pressed Button");	
				this.audio.Play();
								door.Open ();
				if (door.AutoClose) {
					StartCoroutine(Close());
				}
						}
				}
}
}
