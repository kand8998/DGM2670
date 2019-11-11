using UnityEngine;

public abstract class ACharacterBase : MonoBehaviour, IMoving
{
    public float moveSpeed = 3f;
    public float gravity = 3f;
    public float jumpSpeed = 10;
    public CharacterController Controller { get; set;}
    protected Vector3 Location;
    protected Vector3 Orientation;

    public virtual void Move()
    {
        Location.x = Input.GetAxis("Horizontal")*moveSpeed;
        Location.y += gravity * Time.deltaTime;
        Controller.Move(Location * Time.deltaTime);
    }

    public virtual void Jump()
    {
        Location.y = jumpSpeed;
    }
    
    public virtual void Grounded()
    {
        if (Controller.isGrounded)
        {
            Location.x = Input.GetAxis("Horizontal")*moveSpeed;
        }
    }

    public virtual void SwapCharacterClass(CharacterBase character)
    {
        //work
    }


}
