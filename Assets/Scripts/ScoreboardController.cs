using UnityEngine;
using System.Collections;

public class ScoreboardController : MonoBehaviour {

	int leftScore = 0;
	int rightScore = 0;
	int boardWidth = 100;
	int boardHeight = 50;

	void OnGUI () {
		GUI.Box(new Rect((Screen.width - boardWidth)/2, (3*boardHeight)/2, boardWidth, boardHeight), "Scoreboard\n" + leftScore + " : " + rightScore);
	}

	public void LeftScored () {
		leftScore++;
	}

	public void RightScored () {
		rightScore++;
	}

}
