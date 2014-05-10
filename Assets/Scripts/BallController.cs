using UnityEngine;
using System.Collections;

public class BallController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		this.GetComponent<Rigidbody2D>().velocity = new Vector2(2, 2);
	}
	
	public void ResetBall () {
		this.GetComponent<Transform>().position = new Vector3(0, 0, 0);
	}
}
