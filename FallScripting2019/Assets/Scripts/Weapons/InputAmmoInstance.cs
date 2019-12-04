using UnityEngine;

public class InputAmmoInstance : MonoBehaviour
{
    public WeaponConfig weaponObj;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            weaponObj.RaiseFireAction();
        }
    }
}
