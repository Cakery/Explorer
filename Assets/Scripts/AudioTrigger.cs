using UnityEngine;
using System.Collections;

public class AudioTrigger : MonoBehaviour {
	public bool PlayOnce;

	void OnTriggerEnter() {
		if (!this.audio.isPlaying) {
						if (!PlayOnce) {
								this.audio.Play ();
								
						}
				}
	}
}
