using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnBecameInvisible()
    {
        Destroy(this.gameObject);
    }

    public void OnCollisionEnter2D(Collision2D collider)
    {
        if (collider.gameObject.tag == "Bullet")
        {
            Destroy(this.gameObject);
        }
    }
}
