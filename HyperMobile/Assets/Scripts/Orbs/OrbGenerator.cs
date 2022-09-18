using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbGenerator : MonoBehaviour
{
    public GameObject[] orbFall;
    public bool orbGenerator = false;
    public int orbLocation;
    public int orbColor;

    private void Update()
    {
        if (!orbGenerator)
        {
            orbGenerator=true;
            orbLocation = Random.Range(1, 4);
            orbColor = Random.Range(0, 3);
            StartCoroutine(DelayGenerator());
        }
    }

    IEnumerator DelayGenerator()
    {
        GameObject clone;
        clone = Instantiate(orbFall[orbColor], new Vector3(-1.5f, 5f, 0f), Quaternion.identity) as GameObject;
        yield return new WaitForSeconds(0.5f);
        orbGenerator = false;
        Destroy(clone, 4f);
    }
}
