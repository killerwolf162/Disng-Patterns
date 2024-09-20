using UnityEngine;

public class Beam : IBeam
{
    public int damage { get; set; }
    public BeamType beamTypes { get; set; } = BeamType.Normal;

    public Beam(int _damage)
    {
        damage = _damage;
    }

    public void Hit()
    {
        Debug.Log("Do the damage: " + damage + " " + beamTypes);
    }
}
