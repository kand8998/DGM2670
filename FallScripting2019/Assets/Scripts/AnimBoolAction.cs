using UnityEngine;

public class AnimBoolAction : MonoBehaviour
{
    public Animator animator;
    public GameAction boolAction;

    private void Start()
    {
        animator = gameObject.GetComponent<Animator>();
        boolAction.action += CanWalkBool;
    }

    private void CanWalkBool()
    {
        animator.SetBool("CanWalk", true);
    }
}