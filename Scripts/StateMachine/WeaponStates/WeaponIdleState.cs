using UnityEngine;

namespace FSMTest
{
    public class WeaponIdleState : AState
    {

        // give acces to beam class to selet beam type
        private ShootBeam shootBeam;

        public override void Start(IStateRunner runner)
        {
            Debug.Log("Weapon IDLE");
            shootBeam = runner.SharedData.Get<ShootBeam>("ShootBeam");
        }

        public override void Update(IStateRunner runner)
        {

            if(Input.GetKeyDown(KeyCode.Alpha1))
            {

                shootBeam.DecorateWithFire();
            }
            if (Input.GetKeyDown(KeyCode.Alpha2))
            {

                shootBeam.DecorateWithIce();
            }

            if (Input.GetKeyDown(KeyCode.E))
            {
                onSwitch(new WeaponChargingState());
            }

        }
    }

}