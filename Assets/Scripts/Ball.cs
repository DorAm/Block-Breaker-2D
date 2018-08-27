using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
	// config params
	[SerializeField] private Paddle paddle1;
	[SerializeField] private float xPush = 0;
	[SerializeField] private float yPush = 2f;
	
	// state
	private Vector2 paddleToBallVector;
	private bool ballLaunched = false;

	// Use this for initialization
	void Start ()
	{
		paddleToBallVector = transform.position - paddle1.transform.position;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (!ballLaunched)
		{
			LockBallToPaddle();
		}
		LaunchOnMouseClick();
	}

	private void LockBallToPaddle()
	{
		Vector2 paddlePosition = new Vector2(paddle1.transform.position.x, paddle1.transform.position.y);
		transform.position = paddlePosition + paddleToBallVector;
	}

	private void LaunchOnMouseClick()
	{
		if (Input.GetMouseButtonDown(0))
		{
			ballLaunched = true;
			GetComponent<Rigidbody2D>().velocity = new Vector2(xPush, yPush);
		}	
	}
}
