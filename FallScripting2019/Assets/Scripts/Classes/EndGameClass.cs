using System;
using UnityEngine;
using UnityEngine.Events;

public class EndGameClass : MonoBehaviour
{
    public GameAction gameActionObj;
    private void OnMouseDown()
    {
        gameActionObj.Raise();
    }
}
