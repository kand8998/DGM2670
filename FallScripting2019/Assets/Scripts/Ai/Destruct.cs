using System;
using UnityEngine;
using UnityEngine.Events;

public class Destruct : MonoBehaviour
{
    public float destructTime = 3f;
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject, destructTime + 0.1f);
    }
}
