using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{
    public float count = 3.0f;
    private float timeDestroy = 2.3f;
    public Text countdownText;

    // Update is called once per frame
    void Update()
    {
        if (count > 1.0)
        {
            count -= Time.deltaTime;
            countdownText.text = count.ToString("0.0");
        }
        else if (count <= 1.0)
        {
            countdownText.text = "GO!";
        }
        Destroy(countdownText, timeDestroy);
    }
}
