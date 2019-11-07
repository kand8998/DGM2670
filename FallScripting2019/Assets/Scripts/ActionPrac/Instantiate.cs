using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Instantiate : MonoBehaviour
{
    public Rigidbody projectile;
    public Transform launchTransform;
    private GameAction instanceAction;

    private void Start()
    {
        instanceAction.action += Instancing;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
           instanceAction.Raise();
        }
    }

    private void Instancing()
    {
        var projectileInstance = Instantiate(projectile, launchTransform.position,
            launchTransform.rotation);
        projectileInstance.AddForce(launchTransform.up * 350f);
    }
}
