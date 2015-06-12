using UnityEngine;
using System.Collections;

public class PickUp : MonoBehaviour {
	public GameObject Player;

	private bool PickedUp;
	private bool Found;

//	private bool CoolingDown;
	//This is a function to see if the player hit box is within range of the objects hitbox.
	void InRange() {
		Collider[] hitColliders = Physics.OverlapSphere(this.transform.position, 2);
		foreach (Collider I in hitColliders) {
			if (I==Player.collider) {
				Found=true;
			}
				}
	}

	// Update is called once per frame
	void Update () {
		if (Found != true) {
						InRange ();
				}
		//If the velocity is not constantly set to 0, the object will have a tendacy to float away.
		if (PickedUp) {
			this.rigidbody.velocity=Vector3.zero;
				}
		//This code here lets you pick up the object, it parents it to the player and then disables the gravity.
		if (PickedUp&Input.GetButton ("Fire1")) {
			Physics.IgnoreCollision(this.collider,Player.collider,false);
			this.transform.parent=null;
			this.rigidbody.useGravity=true;

			PickedUp=false;
			Found=false;
			Debug.Log("Dropped Object, state="+PickedUp);
			this.audio.Play();
		}
		else if (Input.GetButton ("Fire1") & Found) {
//			CoolingDown=true;
			this.transform.parent=Player.transform;
			this.rigidbody.useGravity=false;
			Physics.IgnoreCollision(this.collider,Player.collider);
			PickedUp=true;
			Debug.Log ("Picked up Object, state="+PickedUp);
			this.audio.Play();
	}

		if (Vector3.Distance (this.transform.position, Player.transform.position) > 4&PickedUp) {
			PickedUp=false;
			this.transform.parent=null;
			this.rigidbody.useGravity=true;
			this.audio.Play();
				}
}
}

