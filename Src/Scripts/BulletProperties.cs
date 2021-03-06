﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletProperties : BulletBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        speed = 20;
        base.Start();
    }

    // Update is called once per frame
    void Update()
    {
        base.Update();
    }

    void OnBecameInvisible()
    {
        Destroy(this.gameObject);
    }

    public void OnCollisionEnter2D(Collision2D collider)
    {
        if (collider.gameObject.tag == "Bomb")
        {
            Destroy(this.gameObject);
            GameManager.points++;
        }
    }
}
