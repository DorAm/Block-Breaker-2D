using System.Diagnostics;
using UnityEngine;
using UnityEngine.Serialization;

public class Paddle : MonoBehaviour
{
	// configuration parameters
	[SerializeField] private float minX = 1f;
	[SerializeField] private float maxX = 15f;
	
	[SerializeField] private float screenWidthInUnits = 16f;

    public PlayerPrefs playerPrefs;
    private void Start()
    {
        playerPrefs = FindObjectOfType<PlayerPrefs>();
        playerPrefs.IncLevel();
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
