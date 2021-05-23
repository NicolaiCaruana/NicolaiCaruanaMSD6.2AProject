using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankShoot : MonoBehaviour
{
    [SerializeField] GameObject Bullet;

    private Coroutine ShootContinuously;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var newRotation = Quaternion.LookRotation(transform.position - Data.Target, Vector3.forward);
        newRotation.x = 0f;
        newRotation.y = 0f;

        transform.rotation = newRotation;
        transform.rotation = Quaternion.Slerp(transform.rotation, newRotation, Time.deltaTime * 8);

        if (Input.GetMouseButtonDown(0))
        {
            ShootContinuously = StartCoroutine(SMFireContinuously());
        }

        if (Input.GetMouseButtonUp(0))
        {
            StopCoroutine(ShootContinuously);
        }
    }

    IEnumerator SMFireContinuously()
    {
        while (true)
        {
            Instantiate(Bullet, this.transform.position, Quaternion.identity);
            yield return new WaitForSeconds(0.5f);
        }
    }
}
