using UnityEngine;
using System.Collections;

public class BoundsController : MonoBehaviour {

	void OnTriggerExit2D (Collider2D other) {
		if (other.tag == "Ball") {
			other.gameObject.GetComponent<BallController>().ResetBall();
		}
	}
}
