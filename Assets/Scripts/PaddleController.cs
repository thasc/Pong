using UnityEngine;
using System.Collections;

public class PaddleController : MonoBehaviour {

	public bool IsLeftPaddle;
	public float Speed;

	void Update () {

		bool pressedUp = IsLeftPaddle ? Input.GetKey(KeyCode.Q) : Input.GetKey(KeyCode.O);
		bool pressedDown = IsLeftPaddle ? Input.GetKey(KeyCode.A) : Input.GetKey(KeyCode.L);

		Rigidbody2D rigidbody = this.GetComponent<Rigidbody2D>();

		if (pressedUp) {
			rigidbody.velocity = new Vector2(0, Speed);
		}
		if (pressedDown) {
			rigidbody.velocity = new Vector2(0, -Speed);
		}
		if(!(pressedUp ^ pressedDown)) {
			rigidbody.velocity = Vector2.zero;
		}
	}

}
