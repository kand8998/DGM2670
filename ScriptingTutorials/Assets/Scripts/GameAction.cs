using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class GameAction : ScriptableObject
{
    public UnityAction action;
    public object call;

    public void Raise()
    {
        action?.Invoke();
    }
}
