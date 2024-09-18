using UnityEngine;

namespace FSMTest
{
    public class WeaponFireingState : AState
    {
        private float timer = 0;
        private float beamUpTime;
        public override void Start(IStateRunner runner)
        {
            Debug.Log("Weapon started fireing");
            beamUpTime = runner.SharedData.Get<float>("BeamUpTime");
        }

        public override void Update(IStateRunner runner)
        {
            timer += Time.deltaTime;

            if (timer > beamUpTime)
            {
                Debug.Log("Weapon stopped fireing");
                onSwitch(new WeaponIdleState());
            }
        }
    }

}