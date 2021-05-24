using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Avoidables : MonoBehaviour
{
    [SerializeField] List<GameObject> enemies;
    [SerializeField] float spawntime = 1f;

    int pickenemy = 0;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnProjectile());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpawnProjectile()
    {
        while (true)
        {
            pickenemy = Mathf.RoundToInt(Random.Range(0, enemies.Count));


            Vector3 enemyPos = new Vector3(Random.Range(Data.XMin, Data.XMax), Data.YMax, 0f);
            Instantiate(enemies[pickenemy], enemyPos, Quaternion.identity);
            yield return new WaitForSeconds(spawntime);
        }
    }
}
