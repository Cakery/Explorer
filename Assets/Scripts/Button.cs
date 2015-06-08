using UnityEngine;
using System.Collections;

public class Button : MonoBehaviour {
	void Start () {

		//Screen.showCursor = false;
		//Debug.Log (transform.position);
		//Vector3 Offset = new Vector3 (20, 0, 0);
	}
	IEnumerator Close() {
		yield return new WaitForSeconds(5);
		door.Close ();
	}
	Vector3 Offset = new Vector3 (0, 20, 0);
	public Door door;

	// Update is called once per frame
	void Update () {
		if (Input.GetButton ("Fire1") & Physics.Raycast (transform.position, transform.TransformDirection (Vector3.forward - Offset), 2)) {
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
