using UnityEngine;


public class CharacterMoveJump : ACharacterBase, IMoving
{
    public override void Move()
    {
       Jump();
       base.Move();
    }
}
