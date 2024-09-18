using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    
    public virtual void FireWeapon()
    {
        
    }

    public virtual void Reload()
    {
        Debug.Log("Weapon reloading");
    }

    public virtual void Recharge()
    {
        Debug.Log("Weapon recharging");
    }

}
