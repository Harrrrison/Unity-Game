using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorScript : Interactable
{
    
    public CapturePoint Captured;
    void Start()
    {
        GetComponent<BoxCollider2D>().enabled = true;

    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<BoxCollider2D>().enabled = true;
        if (Captured)
            GetComponent<BoxCollider2D>().enabled = false;
    }
}
