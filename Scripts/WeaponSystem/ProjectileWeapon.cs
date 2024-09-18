using UnityEngine;

public class ProjectileWeapon : Weapon
{

    public const int ammoCount = 30;
    public const int reloadSpeed = 10;

    public override void FireWeapon()
    {
        Debug.Log("Fireing projectile weapon");
    }

    public override void Reload()
    {
        base.Reload();
    }

}
