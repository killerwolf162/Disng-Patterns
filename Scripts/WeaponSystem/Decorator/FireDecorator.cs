using UnityEngine;

public class FireDecorator : ProjectileDecorator
{
    public FireDecorator(int _damage) : base(_damage) { }

    public override IProjectile Decorate(IProjectile _projectile)
    {
        Debug.Log("Add Some Fire To It!");
        _projectile.projectileDamage += Damage;
        _projectile.protjectileTypes |= protjectileTypes.Fire;

        return _projectile;
    }
}

