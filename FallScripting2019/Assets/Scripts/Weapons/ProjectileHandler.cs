using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class ProjectileHandler : MonoBehaviour
{
    private Rigidbody rigidbodyObj;
    public Vector3 forces;
    public ShootConfig shootObj;


    private void Start()
    {
        rigidbodyObj = GetComponent<Rigidbody>();
        rigidbodyObj.AddForce(forces);
        Destroy(gameObject, 1.5f);
    }
}
