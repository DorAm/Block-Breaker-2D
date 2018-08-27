using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Block : MonoBehaviour
{
    private Level level;

    private void Start()
    {
        level = FindObjectOfType<Level>();
        level.IncBreakableBlocksCount();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
        level.BlockDestroyed();
    }
}
