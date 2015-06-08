using UnityEngine;
using System.Collections;

public class PressurePlateComp : MonoBehaviour {
	public PressurePlate Plate1;
	public PressurePlate Plate2;

	public Door Door;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	if (Plate1.Found & Plate2.Found) {
			Door.Open();
				}
	}
}
