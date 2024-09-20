public abstract class BulletDecorator
{

    public int damage { get; set; }
    public BulletDecorator(int _damage)
    {
        damage = _damage;
    }

    public abstract IBullet Decorate(IBullet bullet);

}
