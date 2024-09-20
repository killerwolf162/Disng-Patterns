using UnityEngine;

public class ShootBeam : MonoBehaviour
{
    IBeam beam = new Beam(5);
    BeamFireDecorater fireDecorater = new BeamFireDecorater(10);
    BeamIceDecorater iceDecorater = new BeamIceDecorater(10);

    public void DecorateWithFire()
    {
        beam = fireDecorater.Decorate(beam);
    }
    public void DecorateWithIce()
    {
        beam = iceDecorater.Decorate(beam);
    }

    public void Shoot()
    {
        beam.Hit();
    }
}
