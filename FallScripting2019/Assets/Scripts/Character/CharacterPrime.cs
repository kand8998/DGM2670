using UnityEngine;

public class CharacterPrime : ACharacterBase
{
    public void Move()
    {
        Location.Set(Input.GetAxis("Vertical")*moveSpeed,0,0);
        Orientation.y = Input.GetAxis("Horizontal")*jumpSpeed;
        
        Transform transform;
        (transform = Controller.transform).Rotate(Orientation);
        Controller.transform.TransformDirection(transform.position);
        
        Controller.Move(Location * Time.deltaTime);
    }
}