using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour {

    public Text TalkingText;
    public float TalkSpeed;

    string[] textTypeWrite = new string[] { "" };
    int currentlyDisplayingText = 0;

    void Awake()
    {
        StartCoroutine(AnimateText());
    }

    public void SkipToNextText()
    {
            StopAllCoroutines();
            currentlyDisplayingText++;

            if (currentlyDisplayingText > textTypeWrite.Length)
            {
                currentlyDisplayingText = 0;
            }

            StartCoroutine(AnimateText());
     }
    IEnumerator AnimateText()
    {

        for (int i = 0; i < (textTypeWrite[currentlyDisplayingText].Length + 1); i++)
        {
            TalkingText.text = textTypeWrite[currentlyDisplayingText].Substring(0, i);
            yield return new WaitForSeconds(0.1f);
        }
    }
}
