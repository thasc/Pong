using UnityEngine;
using System.Collections;

public class PaddleController : MonoBehaviour {

	public bool Left;
	public float Speed;

	void Update () {
		Rigidbody2D rigidbody = this.GetComponent<Rigidbody2D>();
		if (Left) {

		 	bool pressedUp = Input.GetKey(KeyCode.Q);
			bool pressedDown = Input.GetKey(KeyCode.A);

			if (pressedUp) {
				rigidbody.velocity = new Vector2(0, Speed);
			}
			if (pressedDown) {
				rigidbody.velocity = new Vector2(0, -Speed);
			}
			if(!pressedUp && !pressedDown) {
				rigidbody.velocity = Vector2.zero;
			}

		} else {

			bool pressedUp = Input.GetKey(KeyCode.O);
			bool pressedDown = Input.GetKey(KeyCode.L);

			if (pressedUp) {
				rigidbody.velocity = new Vector2(0, Speed);
			}
			if (pressedDown) {
				rigidbody.velocity = new Vector2(0, -Speed);
			}
			if(!pressedUp && !pressedDown) {
				rigidbody.velocity = Vector2.zero;
			}

		}
	}
}
