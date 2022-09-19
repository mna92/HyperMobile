using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbCatch : MonoBehaviour
{
    public AudioSource orbCatchAudio;
    void OnTriggerEnter(Collider other)
    {

        if (other.tag == "RedOrb")
        {
            orbCatchAudio.Play();
            ScoreUpdater.score += 1;
            ScoreUpdater.orbCathed += 1;
        }

        if (other.tag == "BlueOrb")
        {
            orbCatchAudio.Play();
            ScoreUpdater.score += 2;
            ScoreUpdater.orbCathed += 1;
        }

        if (other.tag == "GreenOrb")
        {
            orbCatchAudio.Play();
            ScoreUpdater.score += 3;
            ScoreUpdater.orbCathed += 1;
        }
        Destroy(other.gameObject,0.1f);
    }
}
