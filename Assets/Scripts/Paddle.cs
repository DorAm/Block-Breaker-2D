﻿using System.Diagnostics;
using UnityEngine;

public class Paddle : MonoBehaviour
{
	// configuration parameters
	[SerializeField] private float minX = 1f;
	[SerializeField] private float maxX = 15f;
	
	[SerializeField] private float screenWidthInUnits = 16f;

    public PlayerPrefs1 playerPrefs1;
    private void Start()
    {
        playerPrefs1 = FindObjectOfType<PlayerPrefs1>();
        playerPrefs1.IncLevel();
    }



    // Update is called once per frame
    private void Update ()
	{
		float mousePositionInUnits = Input.mousePosition.x / Screen.width * screenWidthInUnits;
		Vector2 paddlePosition = new Vector2(transform.position.x, transform.position.y);
		paddlePosition.x = Mathf.Clamp(mousePositionInUnits, minX, maxX);
        transform.position = paddlePosition;
	}
}
