using UnityEngine;

[CreateAssetMenu]
public class CharacterMover : ScriptableObject
{
    public float moveSpeed = 10f, jumpSpeed = 30f, gravity = 10f;
    private Vector3 position;
    public IntData jumpData;
    
    public void MoveCharacter(CharacterController controller)
    {
        position.x = moveSpeed * Input.GetAxis("Horizontal");
        position.z = moveSpeed * Input.GetAxis("Vertical");
        position.y -= gravity;

        if (Input.GetButtonDown("Jump") && jumpData.value < jumpData.maxValue)
        {
            position.y = jumpSpeed;
            jumpData.value++;
        }
        else if (controller.isGrounded)
        {
            position.y = 0;
        }
        controller.Move(position * Time.deltaTime);
    }
}
