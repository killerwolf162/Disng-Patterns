using UnityEngine;

public class BulletFireDecorater : BulletDecorator
{
    public BulletFireDecorater(int damage) : base(damage) { }

    public override IBullet Decorate(IBullet bullet)
    {
        Debug.Log("Add some fire to it");
        //bullet.bulletTypes |= BulletType.Fire;
        bullet.Damage += Damage;
        return bullet;
    }

}
