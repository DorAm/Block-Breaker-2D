using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInit : MonoBehaviour
{
	void Start () {
		UnityEngine.PlayerPrefs.SetInt("level", 0);
		UnityEngine.PlayerPrefs.SetInt("score", 0);
	}
}	

