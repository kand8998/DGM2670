using Tutorial_Variants;
using UnityEngine;
[CreateAssetMenu]
public class CharacterMoveJump : ACharacterBase, IMove
{
    public Vector3 location { get; set; }
    public override void Move(CharacterController controller)
    {
     
        Location.Set(0,-gravity,0);
        Controller.Move(location * Time.deltaTime);
    }
}
