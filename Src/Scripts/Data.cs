using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Data : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public static Vector3 Target
    {
        get { return GetTarget(); }
    }

    private static Vector3 GetTarget()
    {
        Vector3 mousepos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousepos = new Vector3(0, mousepos.y, 0);
        return mousepos;
    }

    public static float XMin
    {
        get { return Camera.main.ViewportToWorldPoint(new Vector3(0, 0, 0)).x; }
    }

    public static float XMax
    {
        get { return Camera.main.ViewportToWorldPoint(new Vector3(1, 0, 0)).x; }
    }

    public static float YMin
    {
        get { return Camera.main.ViewportToWorldPoint(new Vector3(0, 0, 0)).y; }
    }

    public static float YMax
    {
        get { return Camera.main.ViewportToWorldPoint(new Vector3(0, 1, 0)).y; }
    }
}
