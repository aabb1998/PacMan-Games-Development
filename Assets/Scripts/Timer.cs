using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Timer : MonoBehaviour
{

    public Text timerText;
    private float startTime;

    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        float t = Time.time - startTime;
        string minutes = Mathf.Floor((int) t / 60).ToString("00");
        // ((int) t / 60).ToString();
        // string seconds = (t % 60).ToString("f2");
        string seconds = (t % 60).ToString("00");
        string ms = ((t * 100f) % 100).ToString("00");
        timerText.text = minutes + ":" + seconds + ":" + ms;
    }
}
