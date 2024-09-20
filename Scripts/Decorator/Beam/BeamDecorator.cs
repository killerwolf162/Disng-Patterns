public abstract class BeamDecorator
{

    public int damage { get; set; }
    public BeamDecorator(int _damage)
    {
        damage = _damage;
    }

    public abstract IBeam Decorate(IBeam beam);

}
