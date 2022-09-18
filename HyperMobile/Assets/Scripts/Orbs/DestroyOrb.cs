using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOrb : MonoBehaviour
{
    public GameObject orbDestroy;
    private void Update()
    {
        Destroy(orbDestroy, 5f);
    }
}
