public interface IProjectile
{
    int projectileSize { get; set; }
    int projectileSpeed { get; set; }
    int projectileDamage { get; set; }

    ProjectileType protjectileTypes { get; set; }

    void LoadProjectileType();

}

