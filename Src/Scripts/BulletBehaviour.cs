using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour
{
    protected float speed;
    private Vector2 direction;
    // Start is called before the first frame update
    protected virtual void Start()
    {
        direction = Data.Target - new Vector3(0f, -8f, 0f);
        direction.Normalize();
        GetComponent<Rigidbody2D>().velocity = direction * speed;
    }

    // Update is called once per frame
    protected virtual void Update()
    {
        
    }
}
