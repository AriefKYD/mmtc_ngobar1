using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class SO_BaseWeapon : ScriptableObject
{
    public WeaponStat weaponStat;
    public abstract void Attack();
    public abstract void Reload();
}

[System.Serializable]
public struct WeaponStat
{
    public float damage;
    public float fireRate;
    public int magazine;
    public int maxAmmo;
}
