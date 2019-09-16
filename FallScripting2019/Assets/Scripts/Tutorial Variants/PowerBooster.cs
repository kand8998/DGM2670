﻿using System;
using UnityEngine;

public class PowerBooster : MonoBehaviour
{

    public float speed = 1f;
    public enum PowerStates
    {
        Normal,
        Fast,
        Slow,
        Stop
    }

    public PowerStates powerState = PowerStates.Normal;

    private void OnTriggerEnter(Collider other)
    {
        
    }

    private void Update()
    {
        switch (powerState)
        {
            case PowerStates.Normal:
                Normal();
                break;
            case PowerStates.Fast:
                Fast();
                break;
            case PowerStates.Slow:
                Slow();
                break;
            case PowerStates.Stop:
                Stop();
                break;
        }
        var speedVector = new Vector3(speed,0,0)*Time.deltaTime;
        transform.Translate(speedVector);
    }

    public void Normal()
    {
        speed = 1f;
    }
    public void Fast()
    {
        speed = 5f;
    }
    public void Slow()
    {
        speed = 0.2f;
    }
    public void Stop()
    {
        speed = 0f;
    }
}
