﻿using UnityEngine;

public class UsingInstantiate : MonoBehaviour
{
    // Unity Tutorial Variant

    public Rigidbody projectile;
    public Transform barrelEnd;
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            Rigidbody projectileInstance;
            projectileInstance = Instantiate(projectile, barrelEnd.position,
                barrelEnd.rotation) as Rigidbody;
            projectileInstance.AddForce(barrelEnd.up * 350f);
        }
    }
}
