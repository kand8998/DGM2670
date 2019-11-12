using UnityEngine;

public class InstantiateAction : MonoBehaviour
{
    public Rigidbody projectile;
    public Transform launchTransform;
    public GameAction instanceAction;

    private void Start()
    {
        instanceAction.action += Instance;
    }
    
    private void Instance()
    {
        var projectileInstance = Instantiate(projectile, launchTransform.position,
            launchTransform.rotation);
        projectileInstance.AddForce(launchTransform.forward * 350f);
    }
}
