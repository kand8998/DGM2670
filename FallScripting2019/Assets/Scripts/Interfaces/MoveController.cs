using System;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class MoveController : MonoBehaviour
{
    private CharacterController controller;
    public ScriptableObject mover;
    private IMove iMover;
    public int i;

    public ScriptableObject[] movers;
    private void Start()
    {
        controller = GetComponent<CharacterController>();
        iMover = movers[0] as IMove;
    }
    
    public void ChangeMover()
    {
        if (i < movers.Length -1)
        {
            i++;
            iMover = movers[i] as IMove;
        }
        else
        {
            i = 0;
            iMover = movers[i] as IMove;
        }
    }
    
    public void ChangeMover(ScriptableObject newMover)
    {
        iMover = newMover as IMove;
    }

    private void Update()
    {
        iMover.Move(controller);
    }
}
