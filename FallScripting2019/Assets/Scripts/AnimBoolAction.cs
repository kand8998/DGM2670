using UnityEngine;

public class AnimBoolAction : MonoBehaviour
{
    public Animator animator;
    public GameAction trueBoolAction, falseBoolAction;

    private void Start()
    {
        animator = gameObject.GetComponent<Animator>();
        trueBoolAction.action += CanWalkBool;
        falseBoolAction.action += IdleBool;
    }

    private void CanWalkBool()
    {
        animator.SetBool("CanWalk", true);
    }

    private void IdleBool()
    {
        animator.SetBool("CanWalk", false);
    }
}