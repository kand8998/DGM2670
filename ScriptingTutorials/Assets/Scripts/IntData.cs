﻿using UnityEngine;
[CreateAssetMenu]
public class IntData : ScriptableObject
{
    public int value = 0;
    public int maxValue = 4;

    public void UpdateToMaxValue()
    {
        value = maxValue;
    }

    public void UpdateValue(int number)
    {
        value += number;
    }

    public void UpdatetoNumber(int number)
    {
        value = number;
    }
}