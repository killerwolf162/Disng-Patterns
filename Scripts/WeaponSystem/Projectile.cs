using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : IProjectile
{

    public int projectileSize { get; set; }
    public int projectileSpeed { get; set; }
    public int projectileDamage { get; set; }

    public projectileType projectileTypes { get; set; } = ProjectileType.normal;

    public Projectile(int damage, int size, int speed)
    {
        projectileSize = size;
        projectileSpeed = speed;
        projectileDamage = damage;
    }

    public void LoadProjectileType()
    {
        Debug.Log("Loading" /* + ProjectileType */ + " " + projectileDamage);
    }

}

