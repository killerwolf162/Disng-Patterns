public interface IBeam
{
    public int BeamLength { get; set; }
    public int beamWidth { get; set; }
    public int beamDamagePerSecon { get; set; }

    void LoadBeamType();
}

