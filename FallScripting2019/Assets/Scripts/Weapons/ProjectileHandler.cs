using UnityEngine;
using UnityEngine.Serialization;

[RequireComponent(typeof(Rigidbody))]
public class ProjectileHandler : MonoBehaviour
{
    private Rigidbody rigidbodyObj;
    public Vector3 forces;
    public ShootConfig shootObj;
    
    void Start()
    {
        var renderer = GetComponent<Renderer>();
        renderer.material.color = shootObj.weaponColor;
        rigidbodyObj = GetComponent<Rigidbody>();
        rigidbodyObj.AddForce(forces);
        Destroy(gameObject, 1f);
    }

    private void OnTriggerEnter(Collider other)
    {
        shootObj.DoDamage();
    }
}
