using UnityEngine;

namespace FSMTest
{
    public class WeaponIdleState : AState
    {
        public override void Start(IStateRunner runner)
        {
            Debug.Log("Weapon IDLE");
        }

        public override void Update(IStateRunner runner)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                onSwitch(new WeaponChargingState());
            }

        }
    }

}