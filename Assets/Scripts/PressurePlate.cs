using UnityEngine;
using System.Collections;

public class PressurePlate : MonoBehaviour {
	public GameObject Object;
	public Light Light1;
	

	public bool Found;
	// Use this for initialization
	void Start () {
	
	}

	void InRange() {
		Collider[] hitColliders = Physics.OverlapSphere(this.transform.position, 2);
		foreach (Collider I in hitColliders) {
			if (I==Object.GetComponent<Collider>()) {
				Found=true;
			}
		}
	}
	IEnumerator Wait() {
		yield return new WaitForSeconds(0.5F);
		Found=false;
	}
	
	// Update is called once per frame
	void LateUpdate () {
		InRange ();

		if (!Found) {
			Light1.color=new Color(255,0,0);
				}
		else if (Found) {
			StartCoroutine(Wait());
			Light1.color=new Color(0,255,0);
			//Found=false;
			}

				}
	}

