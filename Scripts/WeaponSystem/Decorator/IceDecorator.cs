using UnityEngine;

public class IceDecorator : ProjectileDecorator
{
    public IceDecorator(int _damage) : base(_damage) { }

    public override IProjectile Decorate(IProjectile _projectile)
    {
        Debug.Log("Add Some Fire To It!");
        _projectile.projectileDamage += Damage;
        _projectile.protjectileTypes |= protjectileTypes.Ice;

        return _projectile;
    }
}

