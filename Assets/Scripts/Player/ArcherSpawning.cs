﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArcherSpawning : Unit
{
    SpriteRenderer[] srs;
    PolygonCollider2D[] pcs; 
    // Start is called before the first frame update
    void Start()
    {
        srs = this.transform.GetComponentsInChildren<SpriteRenderer>();
        pcs = this.transform.GetComponentsInChildren<PolygonCollider2D>();
        foreach (SpriteRenderer sr in srs) {
            sr.color = new Color(sr.color.r, sr.color.g, sr.color.b, 0.5f); 
        }
        foreach(PolygonCollider2D pc in pcs) { 
            pc.enabled = false; 
        }
    }

    public override void initialise() {
        foreach (SpriteRenderer sr in srs) {
            sr.color = new Color(sr.color.r, sr.color.g, sr.color.b, 1);
        }
        foreach(PolygonCollider2D pc in pcs) { 
            pc.enabled = true; 
        }
    }
}
