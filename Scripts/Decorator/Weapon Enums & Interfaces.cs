using System.Collections;
using System.Collections.Generic;

public enum BulletType
{
    Fire = 1,
    Ice = 3,
    Normal = 5
}

public enum BeamType
{ 
    Fire = 1,
    Ice = 3,
    Normal= 5
}


public interface IBullet
{
    int Damage { get; set; }
    BulletType BulletTypes { get; set; }

    void Hit();
    
}

public interface IBeam
{
    int Damage { get; set; }
    BeamType BeamTypes { get; set; }

    void Hit();
}
