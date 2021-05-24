using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text timer;
    public float time;

    float ms;
    float sec;
    float min;

    // Start is called before the first frame update
    private void Start()
    {
        StartCoroutine("Stopwatch");
    }

    IEnumerator Stopwatch()
    {
        while (true)
        {
            time += Time.deltaTime;
            ms = (int)((time - (int)time) * 100);
            sec = (int)(time % 60);
            min = (int)(time / 60 % 60);

            timer.text = string.Format("{0:00}:{1:00}:{2:00}", min, sec, ms);

            yield return null;
        }
    }


    // Update is called once per frame
    void Update()
    {

    }
}