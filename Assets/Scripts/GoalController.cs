using UnityEngine;
using System.Collections;

public class GoalController : MonoBehaviour {

	public bool LeftGetsPoint;

	public void OnTriggerEnter2D (Collider2D other) {
		if(other.tag == "Ball") {
			if(LeftGetsPoint) {
				GameObject.FindWithTag("Scoreboard").GetComponent<ScoreboardController>().LeftScored();
			} else {
				GameObject.FindWithTag("Scoreboard").GetComponent<ScoreboardController>().RightScored();
			}
			other.GetComponent<BallController>().ResetBall();
		}
	}

}
