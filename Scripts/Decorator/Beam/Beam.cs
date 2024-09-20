using UnityEngine;

public class Beam : IBeam
{
    public int Damage { get; set; }
    public BeamType BeamTypes { get; set; } = BeamType.Normal;

    public Beam(int damage)
    {
        Damage = damage;
    }

    public void Hit()
    {
        Debug.Log("Do the damage: " + Damage + " " + BeamTypes);
    }
}
