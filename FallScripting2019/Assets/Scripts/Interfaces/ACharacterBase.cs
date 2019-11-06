using UnityEngine;

public abstract class ACharacterBase : MonoBehaviour, IMove
{
    public Vector3 location { get; set;}
    public float moveSpeed = 3f;
    public float gravity = 3f;
    public float jumpSpeed = 75;
    public CharacterController Controller { get; set;}
    protected Vector3 Location;
    protected Vector3 orientation;
    
    public abstract void Move(CharacterController controller);

}
