using UnityEngine;
using System.Collections;

public class PickUp : MonoBehaviour {
	public GameObject Player;
	private bool PickedUp;

	// Use this for initialization
	void Start () {

	}
	
	private bool Found;


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
		if (PickedUp) {
			this.rigidbody.velocity=Vector3.zero;
				}
		//hitColliders = Physics.OverlapSphere(this.transform.position, 5);
		if (PickedUp&Input.GetButton ("Fire1")) {
			Physics.IgnoreCollision(this.collider,Player.collider,false);
			this.transform.parent=null;
			this.rigidbody.useGravity=true;

			PickedUp=false;
			Found=false;
			Debug.Log("Dropped Object, state="+PickedUp);
			
		}
		else if (Input.GetButton ("Fire1") & Found) {
			this.transform.parent=Player.transform;
			this.rigidbody.useGravity=false;
			Physics.IgnoreCollision(this.collider,Player.collider);
			PickedUp=true;
			Debug.Log ("Picked up Object, state="+PickedUp);
	}

}
}

