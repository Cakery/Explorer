using UnityEngine;
using System.Collections;

public class Door : MonoBehaviour {
	private bool MovingUp=false;
	private bool MovingDown = false;
	private bool Pressed;
	public Vector3 Direction;
	public int Speed=3;
	public bool AutoClose;

	private Vector3 CurrentPos;

	//Open function, call this to open the door.
	public void Open() {
				if (Pressed != true) {
						this.audio.Play ();
						Pressed = true;
						MovingDown = true;
						CurrentPos = this.transform.position;
				}
		}
	//Close function, call this to close the door.
	public void Close() {
		MovingUp = true;
		this.audio.Play ();
		}
	//All the movement happens here
	void Update () {
	if (MovingDown) {
			this.transform.position=Vector3.MoveTowards(this.transform.position, CurrentPos-Direction,Time.deltaTime*Speed);
	if (this.transform.position==CurrentPos-Direction) {
				MovingDown=false;
				Debug.Log("Door Opened Sucessfully");
		}
}
		if (MovingUp) {
			this.transform.position=Vector3.MoveTowards(this.transform.position, CurrentPos,Time.deltaTime*Speed);
			if (this.transform.position==CurrentPos) {
				MovingUp=false;
				Pressed=false;
				Debug.Log("Door Closed Sucessfully");
			}
		}

}
}