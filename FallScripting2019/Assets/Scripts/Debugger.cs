using UnityEngine;

[CreateAssetMenu]
public class Debugger : ScriptableObject
{
    public void OnDebug(string message)
    {
        Debug.Log(message);
    }

    public void OnDebut(int number)
    {
        Debug.Log(number);
    }
}
