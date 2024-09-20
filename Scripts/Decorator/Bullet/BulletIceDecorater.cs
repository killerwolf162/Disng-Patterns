using UnityEngine;

public class BulletIceDecorater : BulletDecorator
{
    public BulletIceDecorater(int damage) : base(damage) { }

    public override IBullet Decorate(IBullet bullet)
    {
        Debug.Log("Add some ice to it");
        //bullet.bulletTypes |= BulletType.Ice;
        bullet.damage += damage;
        return bullet;
    }

}
