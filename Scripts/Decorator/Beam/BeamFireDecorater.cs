using UnityEngine;

public class BeamFireDecorater : BeamDecorator
{
    public BeamFireDecorater(int damage) : base(damage) { }

    public override IBeam Decorate(IBeam beam)
    {
        Debug.Log("Add some fire to it");
        //bullet.bulletTypes |= BulletType.Fire;
        beam.damage += damage;
        return beam;
    }

}
