using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class AmmoHandler : MonoBehaviour
{
    private Rigidbody rigidbodyObj;
    public Vector3 forces;
    void Start()
    {
        rigidbodyObj = GetComponent<Rigidbody>();
        rigidbodyObj.AddForce(forces);
        Destroy(gameObject, 1f);
    }
}
