public abstract class BeamDecorator
{

    public int Damage { get; set; }
    public BeamDecorator(int damage)
    {
        Damage = damage;
    }

    public abstract IBeam Decorate(IBeam beam);

}
