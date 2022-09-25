using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OrbCatchManager : MonoBehaviour
{
    public GameObject logoFade;
    public GameObject[] tapScreen;
    public GameObject splashBackground;
    public GameObject bgm;
    public GameObject orbHolderOrbGerenator;
    public GameObject timerTimerPanel;
    public GameObject countDownText;
    public AudioSource bip;
    public AudioSource finalBip;
    public GameObject[] scoreEnd;

    void Start()
    {
        StartCoroutine(StartupGame());
    }

    IEnumerator StartupGame()
    {
        yield return new WaitForSeconds(1);
        logoFade.SetActive(true);
        yield return new WaitForSeconds(2.5f);
        logoFade.SetActive(false);
        tapScreen[0].SetActive(true);
        tapScreen[1].SetActive(true);

    }

    public void TapToStart()
    {
        scoreEnd[0].SetActive(false);
        scoreEnd[1].SetActive(false);
        tapScreen[0].SetActive(false);
        tapScreen[0].SetActive(false);
        tapScreen[1].SetActive(false);
        splashBackground.GetComponent<Animator>().Play("SplashFadeOn");
        StartCoroutine(BeginTheGame());
    }

    IEnumerator BeginTheGame()
    {
        yield return new WaitForSeconds (1);
        countDownText.SetActive(true);
        bip.Play();
        yield return new WaitForSeconds(1);
        countDownText.GetComponent<Text>().text = "2";
        bip.Play();
        yield return new WaitForSeconds(1);
        countDownText.GetComponent<Text>().text = "1";
        bip.Play();
        yield return new WaitForSeconds(1);
        countDownText.GetComponent<Text>().text = "GO";
        finalBip.Play();
        yield return new WaitForSeconds(1);
        splashBackground.SetActive(false);
        countDownText.SetActive(false);
        countDownText.GetComponent<Text>().text = "3";
        bgm.SetActive(true);
        orbHolderOrbGerenator.GetComponent<OrbGenerator>().enabled = true;
        timerTimerPanel.GetComponent<Timer>().enabled = true;
    }
}
