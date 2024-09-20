using System;
using UnityEngine;

public class Bullet : IBullet, IPoolable
{
    public int Damage { get; set; }
    public BulletType BulletTypes { get; set; } = BulletType.Normal;
    public bool Active { get; set; }

    public event Action<Bullet> OnHit;

    public Bullet()
    {
        Damage = 5;
    }

    public void Hit()
    {
        Debug.Log("you did " + Damage + "damage");
        OnHit?.Invoke(this);
    }

    public void OnEnableObject()
    {
        Debug.Log("bullet activated");
    }

    public void OnDisableObject()
    {
        Debug.Log("Bullet deactivated");
        OnHit = null;
    }
}