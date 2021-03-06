﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
	[SerializeField] private int breakableBlocks;
	private SceneLoader sceneLoader;

	private void Start()
	{
		sceneLoader = FindObjectOfType<SceneLoader>();
	}

	public void IncBreakableBlocksCount()
	{
		breakableBlocks++;
	}

	public void BlockDestroyed()
	{
		breakableBlocks--;
		if (breakableBlocks <= 0)
		{
			sceneLoader.LoadLevelCompleted();
		}
	}
}
