using UnityEngine;

[CreateAssetMenu]
public class FloatData : ScriptableObject
{
    
    public float value = 1f;
    public float maxValue = 1f;
    
    public void UpdateValue(float amount)
    {
        value += amount;
    }

    public void UpdateValueLimitZero(float amount)
    {
        if (value > 0)
        {
            UpdateValue(amount);
        }
        else
        {
            value = 0;
        }
    }

    public void UpdateValueLimitZeroAndMaxValue(float amount)
    {
        if (value <= maxValue)
        {
            UpdateValue(amount);
        }
        else
        {
            value = maxValue;
        }
        UpdateValueLimitZero(amount);
       
    }
}
