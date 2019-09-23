using UnityEngine;
[CreateAssetMenu]
public class IntData : ScriptableObject
{
    public int value = 0;
    public int maxValue = 2;

    public void UpdateToMaxValue()
    {
        value = maxValue;
    }

    public void UpdatetoNumber(int number)
    {
        value = number;
    }
}
