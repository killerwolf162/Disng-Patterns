using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecorateBullet : MonoBehaviour
{

    IBullet someBullet = new Bullet();
    BulletFireDecorater fireDecorater = new BulletFireDecorater(10);
    BulletIceDecorater iceDecorater = new BulletIceDecorater(10);

    public void DecorateWithFire()
    {
        someBullet = fireDecorater.Decorate(someBullet);
    }
    public void DecorateWithIce()
    {
        someBullet = iceDecorater.Decorate(someBullet);
    }
}
