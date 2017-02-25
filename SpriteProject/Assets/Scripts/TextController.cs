using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour
{
    public AudioSource audioType;
    public AudioSource audioK;
    // La conversation a ete fait avec l'aide d'alex :)
    public Button button1;
    public Button button2;
    public Text text1;

    public Text NPCDialog;
    public int currentChar;
    public float nextTime;
    public int textLevel;
    public float interval = 0.5f;
    public string currentText;

    string[] NPCsText = { "Hi Kirby, are you enjoying your life?",
        "Great, me to! Do you need me for anything?",
        "Oh! I hope you will be well soon. Do you need me for anything?",
        "Okay, awesome, let's go ",
        "Okay Then...goodbye!" };

    void Start()
    {
        setTypeWriter();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            setTypeWriter();
        }
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
        audioType.Play();
        currentText = currentText.Insert(currentChar, NPCsText[textLevel][currentChar].ToString());
        NPCDialog.text = currentText;
    }

    void setTypeWriter()
    {
        currentChar = 0;
        nextTime = 0;
        textLevel = 0;
        currentText = "";
    }

    public void onButtonYessClick()
    {
        audioK.Play();
        switch (textLevel)
        {
            case 0:
                
                NpcAnswer(1);
                
                 break;
            case 1:
                NpcAnswer(3);
                break;
            case 2:
                NpcAnswer(4);
                break;  
                     
        }  
    }
    public void onButtonNoClick()
    {
        switch (textLevel)
        {
            case 0:
                NpcAnswer(2);
                break;
            case 1:
                NpcAnswer(4);
                break;
            case 2:
                NpcAnswer(6);
                break;
        }
    }

    void NpcAnswer(int text)
    {
        currentChar = 0;
        currentText = "";
        textLevel = text;
    }
}
