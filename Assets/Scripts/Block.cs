using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.Serialization;

public class Block : MonoBehaviour {

    private Level level;
    public PlayerPrefs playerPrefs;
    private void Start()
    {
        playerPrefs = FindObjectOfType<PlayerPrefs>();
        level = FindObjectOfType<Level>();
        level.IncBreakableBlocksCount();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
        playerPrefs.AddScore(50);
        level.BlockDestroyed();
    }
}
