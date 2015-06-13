using UnityEngine;
using System.Collections;

public class AudioTrigger : MonoBehaviour {
	public bool PlayOnce;

	void OnTriggerEnter() {
		if (!this.GetComponent<AudioSource>().isPlaying) {
						if (!PlayOnce) {
								this.GetComponent<AudioSource>().Play ();
								
						}
				}
	}
}
