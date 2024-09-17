using UnityEngine;

public class Beam : IBeam
{
    public int BeamLength { get; set; }
    public int beamWidth { get; set; }
    public int beamDamagePerSecon { get; set; }

    //public BeamType BeamTypes { get; set; } = Beamtype.normal;

    public Beam (int _length, int _width, int _damagePerSecond)
    {
        BeamLength = _length;
        beamWidth = _width;
        beamDamagePerSecon = _damagePerSecond;
    }

    public void LoadBeamType()
    {
        Debug.Log("Loading" /* + BeamType */ + " " + beamDamagePerSecon);
    }
}

