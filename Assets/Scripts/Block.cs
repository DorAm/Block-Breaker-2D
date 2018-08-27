using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Block : MonoBehaviour {

    private Level level;
    public PlayerPrefs1 playerPrefs1;
    private void Start()
    {
        playerPrefs1 = FindObjectOfType<PlayerPrefs1>();
        level = FindObjectOfType<Level>();
        level.IncBreakableBlocksCount();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
        playerPrefs1.AddScore(50);
        level.BlockDestroyed();
    }
}
