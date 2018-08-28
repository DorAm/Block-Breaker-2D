using UnityEngine;
using System.Collections;
using System.Diagnostics;
using UnityEngine.UI;
using Debug = UnityEngine.Debug;

// Required when Using UI elements.

public class InputText : MonoBehaviour
{
	public InputField mainInputField;

	private void Update()
	{
		UnityEngine.PlayerPrefs.SetString("name", mainInputField.text);
	}
}
