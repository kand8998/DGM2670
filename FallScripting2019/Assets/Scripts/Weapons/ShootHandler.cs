using System;
using UnityEngine;
using UnityEngine.Serialization;

public class ShootHandler : MonoBehaviour
{
    public ShootConfig shootObj;
    private void Start()
    {
        var child = Instantiate(shootObj.weaponArt, transform);
        shootObj.weaponShootAction = Fire;
    }

    public void Fire()
    {
        var ammo = Instantiate(shootObj.ammoObj);
        ammo.GetComponent<ProjectileHandler>().shootObj = shootObj;
    }

    private void OnTriggerEnter(Collider other)
    {
        shootObj.weaponShootAction();
    }
}
