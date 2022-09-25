using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text seconds;
    public bool countingDown = true;
    float sec = 30;

    public GameObject splashBackground;
    public GameObject bgm;
    public GameObject orbHolderOrbGerenator;
    public GameObject tapToPlayButton;
    public GameObject finalScore;
    public GameObject finalOrbs;
    public GameObject timerTimerPanel;

    private void Update()
    {
        if (countingDown)
        {
            sec -= Time.deltaTime;
            seconds.text = sec.ToString("0.00");
            if (sec <= 0)
            {
                countingDown = false;
                StartCoroutine(EndGame());
            }
        }
    }

    IEnumerator EndGame()
    {
        orbHolderOrbGerenator.GetComponent<OrbGenerator>().enabled = false;
        splashBackground.SetActive(true);
        splashBackground.GetComponent<Animator>().Play("SplashFadeIn");
        bgm.SetActive(false);
        yield return new WaitForSeconds(1.2f);
        tapToPlayButton.SetActive(true);
        finalOrbs.GetComponent<Text>().text = "NUMBER OF ORBS:\n" + ScoreUpdater.orbCathed.ToString();
        finalScore.GetComponent<Text>().text = "SCORE: \n" + ScoreUpdater.score.ToString();
        finalOrbs.SetActive(true);
        finalScore.SetActive(true);
        ScoreUpdater.orbCathed = 0;
        ScoreUpdater.score = 0;
        sec = 30;
        seconds.text = "30";
        countingDown = true;
        timerTimerPanel.GetComponent<Timer>().enabled = false;
    }
}
