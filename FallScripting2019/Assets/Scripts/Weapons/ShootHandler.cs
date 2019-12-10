using System;
using UnityEngine;
using UnityEngine.Serialization;

public class ShootHandler : MonoBehaviour
{
    public ShootConfig shootObj;
    void Start()
    {
        var child = Instantiate(shootObj.weaponArt, transform);
        shootObj.weaponFireAction = Fire;
        var renderer = child.GetComponent<Renderer>();
        renderer.material.color = shootObj.weaponColor;
    }

    public void Fire()
    {
        var ammo = Instantiate(shootObj.ammoObj);
        ammo.GetComponent<ProjectileHandler>().shootObj = shootObj;
    }

    private void OnTriggerEnter(Collider other)
    {
        shootObj.RaiseCollectAction();
    }
}
