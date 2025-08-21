using UnityEngine;

[CreateAssetMenu(fileName = "SO_Auto Shot Weapon", menuName = "SO/Weapon Type/Auto")]
public class SO_AutoShot : SO_BaseWeapon
{
    public override void Attack()
    {
        if (Input.GetMouseButton(0))
            Debug.Log("Auto Shot");
    }

    public override void Reload()
    {
    }
}
