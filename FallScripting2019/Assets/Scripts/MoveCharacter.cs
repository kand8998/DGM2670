using UnityEngine;
using UnityEngine.Events;

public class MoveCharacter : MonoBehaviour
{
    public UnityEvent onGrounded, offGrounded;
    public MoveBase characterMover;
    private CharacterController controller;
    
   private void Start()
   {
       controller = GetComponent<CharacterController>();
   }
   
   private void Update()
    {
        if (controller.isGrounded)
        {
            onGrounded.Invoke();
        }
        else
        {
            offGrounded.Invoke();
        }

        characterMover.Move(controller);
    }
}
