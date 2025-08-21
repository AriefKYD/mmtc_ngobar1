using UnityEngine;

public class WeaponSystem : MonoBehaviour
{
    public SO_BaseWeapon currentWeapon;

    private void Update()
    {
        if(currentWeapon)
        currentWeapon.Attack();
    }
}