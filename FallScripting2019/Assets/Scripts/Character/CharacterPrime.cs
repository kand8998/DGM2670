using UnityEngine;
[CreateAssetMenu]
public class CharacterPrime : CharacterBase
{
    public override void Move()
    {
        Location.Set(Input.GetAxis("Vertical")*speed,0,0);
        Orientation.y = Input.GetAxis("Horizontal")*orientSpeed;
        
        Transform transform;
        (transform = Controller.transform).Rotate(Orientation);
        Controller.transform.TransformDirection(transform.position);
        
        Controller.Move(Location * Time.deltaTime);
    }
}