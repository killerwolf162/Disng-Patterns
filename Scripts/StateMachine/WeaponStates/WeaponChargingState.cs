using UnityEngine;

namespace FSMTest
{
    public class WeaponChargingState : AState
    {
        private float chargeTime;
        private float chargeTimer = 0;
        private float swapTimer = 0;

        public override void Start(IStateRunner runner)
        {
            Debug.Log("Started charging Weapon");
            chargeTime = runner.SharedData.Get<float>("ChargeTime");
        }

        public override void Update(IStateRunner runner)
        {
            swapTimer += Time.deltaTime;
            if(swapTimer > 1)
            {
                if (Input.GetKey(KeyCode.E) != true)
                {
                    Debug.Log("weapon stopped charging");
                    onSwitch(new WeaponIdleState());
                    chargeTimer = 0;
                    swapTimer = 0;
                }

                if (Input.GetKey(KeyCode.E) == true)
                {
                    chargeTimer += Time.deltaTime;

                    if (chargeTime <= chargeTimer)
                    {
                        swapTimer = 0;
                        onSwitch(new WeaponChargedState());
                    }
                }
            }
            

        }
    }

}