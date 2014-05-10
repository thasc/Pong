using UnityEngine;
using System.Collections;

public class GoalController : MonoBehaviour {

	public bool LeftGetsPoint;

	public void OnTriggerEnter2D (Collider2D other) {
		if(other.tag == "Ball") {
			if(LeftGetsPoint) {
				Debug.Log("Left gets a point!");
			} else {
				Debug.Log("Right gets a point!");
			}
			other.GetComponent<BallController>().ResetBall();
		}
	}
}
