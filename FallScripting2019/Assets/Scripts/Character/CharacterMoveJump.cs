using UnityEngine;

[CreateAssetMenu]
public class CharacterMoveJump : ACharacterBase, IMove
{
    public override void Move(CharacterController controller)
    {
        if (Input.GetButton("Jump"))
        {
            Location.y = jumpSpeed;
        }
    }
}
