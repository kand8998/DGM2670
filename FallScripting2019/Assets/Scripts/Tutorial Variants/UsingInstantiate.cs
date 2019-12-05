using System;
using UnityEngine;
using UnityEngine.Events;

public class UsingInstantiate : MonoBehaviour
{
    public Rigidbody projectile;
    public Transform barrelEnd;
    private UnityAction instatiateAction;

    private void Start()
    {
        instatiateAction = Instantiate;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            Instantiate();
        }
    }

    private void Instantiate()
    {
        Rigidbody projectileInstance;
        projectileInstance = Instantiate(projectile, barrelEnd.position,
            barrelEnd.rotation) as Rigidbody;
        projectileInstance.AddForce(barrelEnd.up * 350f);
    }

}
