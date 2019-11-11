using UnityEngine;


public class CharacterMoveWhenGround : ACharacterBase, IMoving
{
    public override void Move()
    {
        Grounded();
        Location.y += gravity * Time.deltaTime;
        Controller.Move(Location * Time.deltaTime);
    }
}
