using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

[CreateAssetMenu]
public class ShootConfig : ScriptableObject
{
    public UnityAction weaponShootAction;
    public GameObject weaponArt;
    public GameObject ammoObj;
    public float firePower = 0.1f;

    public void RaiseShootAction()
    {
        weaponShootAction?.Invoke();
    }
}