using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour {

    public enum State
    {
        kSleeps=0,
        KWakeUp,
        kTalk,
    }

    bool IsSleeping;
    public Text MonText ;
    public Animator m_Animator;
    public SpriteRenderer m_SpriteRenderer;

    void Start()
    {
        
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            m_Animator.SetInteger("SetInteger", (int)State.KWakeUp);

            //m_SpriteRenderer.flipX = true;
        }
        else if (Input.GetKeyUp(KeyCode.S))
        {
            m_Animator.SetInteger("SetInteger", (int)State.kTalk);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            m_Animator.SetInteger("SetInteger", (int)State.kSleeps);

        }

    }

    //public void OnBreathEnd()
    //{
    //    m_Animator.SetInteger("State", (int)State.IdleKriby);
    //}

    public void OnToggleOn()
    {
        
    }
}
