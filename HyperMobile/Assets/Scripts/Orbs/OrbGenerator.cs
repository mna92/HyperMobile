using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbGenerator : MonoBehaviour
{
    public GameObject[] orbFall;
    GameObject clone;
    public float[] horizontalLocation = {-1.5f,0f,1.5f};
    public bool orbGenerator = false;
    public int orbLocation;
    public int orbColor;

    private void Update()
    {
        if (!orbGenerator)
        {
            orbGenerator=true;
            orbLocation = Random.Range(0, 3);
            orbColor = Random.Range(0, 3);
            StartCoroutine(DelayGenerator());
        }
    }

    IEnumerator DelayGenerator()
    {
        clone = Instantiate(orbFall[orbColor], new Vector3(horizontalLocation[orbLocation], 5f, 0f), Quaternion.identity) as GameObject;
        yield return new WaitForSeconds(0.5f);
        orbGenerator = false;
        Destroy(clone,4f);
    }
}
