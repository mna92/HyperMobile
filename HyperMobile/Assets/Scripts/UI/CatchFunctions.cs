using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CatchFunctions : MonoBehaviour
{
    public GameObject leftPlatform;
    public GameObject middlePlatform;
    public GameObject rightPlatform;
    public AudioSource activeAuido;

    public bool activePlatform = false;

    public void PressLeftButton()
    {
        if (!activePlatform)
        {
            activePlatform = true;
            leftPlatform.SetActive(true);
            StartCoroutine(ResetPlatform());
        }
    }

    public void PressMiddleButton()
    {
        if (!activePlatform)
        {
            activePlatform = true;
            middlePlatform.SetActive(true);
            StartCoroutine(ResetPlatform());
        }
    }

    public void PressRightButton()
    {
        if (!activePlatform)
        {
            activePlatform = true;
            rightPlatform.SetActive(true);
            StartCoroutine(ResetPlatform());
        }
    }

    IEnumerator ResetPlatform()
    {
        activeAuido.Play();
        yield return new WaitForSeconds(0.5f);
        leftPlatform.SetActive(false);
        rightPlatform.SetActive(false);
        middlePlatform.SetActive(false);
        activePlatform = false;
    }
}
