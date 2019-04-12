using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine.UI;

public class BlinkingText : MonoBehaviour {

    public float blinking_time = 0.5f;

    private string mtext;

    void Start()
    {
        mtext = this.GetComponent<Text>().text;
        StartCoroutine(Blink());
    }

    IEnumerator Blink()
    {
        while (true)
        {
            this.GetComponent<Text>().text = "";
            yield return new WaitForSeconds(blinking_time / 2);
            this.GetComponent<Text>().text = mtext;
            yield return new WaitForSeconds(blinking_time);
        }
       
    }
}

