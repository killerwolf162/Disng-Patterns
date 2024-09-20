using FSMTest;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
 
    [SerializeField] private ProjectileWeapon projectileWeapon;
    [SerializeField] private BeamWeapon beamWeapon;

    private void Start()
    {
        projectileWeapon.enabled = false;
        beamWeapon.enabled = false;
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.T))
        {
            SwapToBeamWeapon();
        }

        if(Input.GetKeyDown(KeyCode.Y))
        {
            SwapToProjectileWeapon();
        }
    }

    private void SwapToProjectileWeapon()
    {
        Debug.Log("Swapped to projectile weapon");
        projectileWeapon.enabled = true;
        beamWeapon.enabled = false;
    }
    private void SwapToBeamWeapon()
    {
        Debug.Log("Swapped to beam weapon");
        projectileWeapon.enabled = false;
        beamWeapon.enabled = true;
    }

}
