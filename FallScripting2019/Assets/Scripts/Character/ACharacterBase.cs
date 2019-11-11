using UnityEngine;

public abstract class ACharacterBase : MonoBehaviour, IMove
{
    public Vector3 location { get; set;}
    public float moveSpeed = 3f;
    public float gravity = 3f;
    public float jumpSpeed = 10;
    public CharacterController Controller { get; set;}
    protected Vector3 Location;
    protected Vector3 Orientation;

    public virtual void Move(CharacterController controller)
    {
        Location.x = Input.GetAxis("Horizontal")*moveSpeed;
        Location.y += gravity * Time.deltaTime;
        Controller.Move(location * Time.deltaTime);
    }

}
