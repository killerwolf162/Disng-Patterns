using UnityEngine;

public class ProjectileWeapon : Weapon
{
    // link with decorator and objectpool doesnt work correctly
    // both work seperatly but for the decoration to work properly you need to give an argument to bullet for damage
    // but I havent figuerd out how to get this to work.
    // for now the decorator on the projectilw weapon only says that it works but doesnt add the damage just the other effects


    public int ammoCount;
    public int maxAmmo = 30;
    public int reloadSpeed = 10;

    private DecorateBullet shootBullet;

    private ObjectPool<Bullet> bulletPool;

    private void Awake()
    {
        ammoCount = maxAmmo;

        bulletPool = new ObjectPool<Bullet>();

        for (int i = maxAmmo; i < 0; i++)
        {
            bulletPool.AddNewItemToPool();
        }

        shootBullet = GetComponent<DecorateBullet>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            LoadFireBullets();
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            LoadIceBullet();
        }
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            FireWeapon();
        }
        if(Input.GetKeyDown(KeyCode.R))
        {
            Reload();
        }
    }

    public override void FireWeapon()
    {
        if(ammoCount > 0)
        {
            Bullet bullet = bulletPool.RequestObject();
            bullet.OnHit += OnBulletHit;
            ammoCount -= 1;
            bullet.Hit();
            Debug.Log("you fired and have " + ammoCount + " bullets left");
        }
    }

    public void OnBulletHit(Bullet bullet)
    {
        Debug.Log("bullet hit");
        bulletPool.ReturnObjectToPool(bullet);
    }

    public void LoadFireBullets()
    {
        shootBullet.DecorateWithFire();
    }

    public void LoadIceBullet()
    {
        shootBullet.DecorateWithIce();
    }

    public override void Reload()
    {
        ammoCount = maxAmmo;
    }

}
