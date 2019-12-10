using UnityEngine;

public class ShootHandler : MonoBehaviour
{
    public ShootConfig shootObj;
    public Transform launchTransform;
    private void Start()
    {
        var child = Instantiate(shootObj.weaponArt, transform);
        shootObj.weaponShootAction = Fire;
    }

    public void Fire()
    {
        var ammo = Instantiate(shootObj.ammoObj, launchTransform);
        ammo.GetComponent<ProjectileHandler>().shootObj = shootObj;
    }

    private void OnTriggerEnter(Collider other)
    {
        shootObj.weaponShootAction();
    }
}
