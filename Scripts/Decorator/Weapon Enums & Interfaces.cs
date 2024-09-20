using System.Collections;
using System.Collections.Generic;

public enum BulletType
{
    Fire,
    Ice,
    Normal
}

public enum BeamType
{ 
    Fire,
    Ice,
    Normal
}


public interface IBullet
{
    int damage { get; set; }
    BulletType bulletTypes { get; set; }

    void Hit();
    
}

public interface IBeam
{
    int damage { get; set; }
    BeamType beamTypes { get; set; }

    void Hit();
}
