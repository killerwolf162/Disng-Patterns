using System;
using UnityEngine;

public class Bullet : IBullet, IPoolable
{
    public int damage { get; set; }
    public BulletType bulletTypes { get; set; } = BulletType.Normal;
    public bool active { get; set; }

    public event Action<Bullet> OnHit;

    public Bullet()
    {
        damage = 5;
    }

    public void Hit()
    {
        Debug.Log("you did " + damage + "damage");
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