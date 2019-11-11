using UnityEngine;
[CreateAssetMenu]
public abstract class CharacterBase : ScriptableObject, IMove
{
    public Transform characterTransform { get; set;}
    public CharacterController Controller { get; set;}

    public Vector3 location { get; set; }
    protected Vector3 orientation;
    public float speed = 10f;
    public float orientSpeed = 3f;
    
    public void Move(CharacterController controller)
    {
        throw new System.NotImplementedException();
    }

    public void Move()
    {
        throw new System.NotImplementedException();
    }
}
