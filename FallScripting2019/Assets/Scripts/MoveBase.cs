using UnityEngine;

public abstract class MoveBase : ScriptableObject
{
    protected Vector3 Position;
    public float jumpForce = 1f;
    public float gravity = -9.8f;
    public float speed = 15;

    public abstract void Move(CharacterController controller);
}
