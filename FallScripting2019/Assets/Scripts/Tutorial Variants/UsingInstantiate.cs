using UnityEngine;
using UnityEngine.Events;

public class UsingInstantiate : MonoBehaviour
{
    // Unity Tutorial Variant

    public Rigidbody projectile;
    public Transform barrelEnd;
    public GameAction instantiateAction;
    public UnityEvent instantiateEvent;
    private void Start()
    {
        //instantiateAction.action += Instantiate();
    }
    
    private void Instantiate()
    {
        var projectileInstance = Instantiate(projectile, barrelEnd.position,
            barrelEnd.rotation) as Rigidbody;
        projectileInstance.AddForce(barrelEnd.up * 350f);
    }

}
