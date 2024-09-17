using System.Collections;
using System.Collections.Generic;

public abstract class ProjectileDecorator
{
    public int Damage { get; set; }
    public ProjectileDecorator(int _damage)
    {
        Damage = _damage;
    }

    public abstract IProjectile Decorate(IProjectile _projectile);

}

