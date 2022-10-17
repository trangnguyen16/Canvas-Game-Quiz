using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer123 : MonoBehaviour
{
    public float timer = 0f;
    public Text text;
    private void Update()
    {
        timer += Time.deltaTime;
        //Debug.Log(timer);
        text.text = timer.ToString();
    }

}
