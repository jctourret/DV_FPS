using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrosshairAnim : MonoBehaviour
{
    public GameObject dLine;
    public GameObject uLine;
    public GameObject rLine;
    public GameObject lLine;

    float animTimer = 0f;
    float animTimerLimit = 0.1f;
    bool animOver;

    void Update()
    {
        if (Input.GetButtonDown("Fire1") && animOver)
        {
            dLine.GetComponent<Animator>().enabled = true;
            uLine.GetComponent<Animator>().enabled = true;
            rLine.GetComponent<Animator>().enabled = true;
            lLine.GetComponent<Animator>().enabled = true;
            animOver = false;
        }
        waitAnim();
    }

    void waitAnim()
    {
        if (animTimer < animTimerLimit && !animOver)
        {
            animTimer += Time.deltaTime;
        }
        if (animTimer >= animTimerLimit && !animOver)
        {
            dLine.GetComponent<Animator>().enabled = false;
            uLine.GetComponent<Animator>().enabled = false;
            rLine.GetComponent<Animator>().enabled = false;
            lLine.GetComponent<Animator>().enabled = false;
            animOver = true;
            animTimer = 0f;
        }
    }
}
