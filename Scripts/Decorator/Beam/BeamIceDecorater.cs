using UnityEngine;

public class BeamIceDecorater : BeamDecorator
{
    public BeamIceDecorater(int damage) : base(damage) { }

    public override IBeam Decorate(IBeam beam)
    {
        Debug.Log("Add some ice to it");
        //bullet.bulletTypes |= BulletType.Fire;
        beam.damage += damage;
        return beam;
    }

}
