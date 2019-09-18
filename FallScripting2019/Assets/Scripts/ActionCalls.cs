using UnityEngine;

public class ActionCalls : MonoBehaviour
{
    public float speed = 1f, rotateSpeed = 30f, scaleSpeed = 0.2f;
    private Vector3 location, rotations, scales;
    private void Start() {
        
    }
    private void Update() {
        Move();
        OnRotate();
        OnScale();
    }
    public void Move() {
        location.x = speed * Time.deltaTime;
        transform.Translate(location);
    }

    public void OnRotate() {
        rotations.y = rotateSpeed * Time.deltaTime;
        transform.Rotate(rotations);
    }

    public void OnScale(){
        scales.Set(scaleSpeed, scaleSpeed, scaleSpeed);
        transform.localScale = scales;
    }
}
