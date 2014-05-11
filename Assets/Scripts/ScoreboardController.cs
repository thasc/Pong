using UnityEngine;
using System.Collections;

public class ScoreboardController : MonoBehaviour {
	
	int leftScore = 0;
	int rightScore = 0;

	public int GetLeftScore () {
		return leftScore;
	}

	public int GetRightScore () {
		return rightScore;
	}
	
	public void LeftScored () {
		leftScore++;
	}

	public void RightScored () {
		rightScore++;
	}

}
