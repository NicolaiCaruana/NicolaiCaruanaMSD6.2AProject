using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankShoot : MonoBehaviour
{
    [SerializeField] GameObject Bullet;
    float zAxis = 1f;
    float yAxis = -4.86f;
    Vector3 mousePosition;

    private Coroutine Shoot;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.y = yAxis;
        mousePosition.z = zAxis;

        transform.position = mousePosition;
        /*var newRotation = Quaternion.LookRotation(transform.position - Data.Target, Vector3.forward);
        newRotation.x = 0f;
        newRotation.y = 0f;

        transform.rotation = newRotation;
        transform.rotation = Quaternion.Slerp(transform.rotation, newRotation, Time.deltaTime * 8);*/

        if (Input.GetMouseButtonDown(0))
        {
            Shoot = StartCoroutine(Fire());
        }

        if (Input.GetMouseButtonUp(0))
        {
            StopCoroutine(Shoot);
        }
    }

    IEnumerator Fire()
    {
        while (true)
        {
            Instantiate(Bullet, this.transform.position, this.transform.rotation);
            yield return new WaitForSeconds(0.5f);
        }
    }
}
