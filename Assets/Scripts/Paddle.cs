using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Constants;

public class Paddle : MonoBehaviour {
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float mousePositionInUnits = Input.mousePosition.x / Screen.width * Constants.Constants.HORIZONTAIL_UNITS;
        Vector2 paddlePosition = new Vector2(mousePositionInUnits, transform.position.y);
        transform.position = paddlePosition;
	}
}
