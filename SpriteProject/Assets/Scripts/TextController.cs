using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour
{
    public Button button;
    int add = 10;
    public Text NPCDialog;
    public int currentChar;
    public float nextTime;
    public int textLevel;
    public float interval = 0.5f;
    public string currentText;

    string[] PlayersText = { "Yeah Sure", "Nah i am good" };
    string[] NPCsText = { "Hi Kirby, are you enjoying your life?",
        "Great, me to! Do you need me for anything?",
        "Oh! I hope you will be well soon. Do you need me for anything?",
        "Okay Then...goodbye!" };

    void Start()
    {
        setTypeWriter();
    }
    void Update()
    {
        if (Time.time >= nextTime)
        {
            if (currentChar < NPCsText[textLevel].Length)
            {
                Typewriter();
                currentChar++;
            }
            nextTime += interval;
        }

    }
    void Typewriter()
    {
        currentText = currentText.Insert(currentChar, NPCsText[textLevel][currentChar].ToString());
        NPCDialog.text = currentText;
    }

    void setTypeWriter()
    {
        currentChar = 0;
        nextTime = 0;
        textLevel = 0;
        currentText = " ";
    }

    public void onButtonYessClick()
    {
        add = add + 1;
    }
    public void onButtonNoClick()
    {
        add = add - 1;
    }
    void Conversation()
    {
        switch(add)
        {
            case 11:
                Debug.Log("yio");
                break;
            case 9:
                Debug.Log("hilala");
                break;
        }
    }


}
