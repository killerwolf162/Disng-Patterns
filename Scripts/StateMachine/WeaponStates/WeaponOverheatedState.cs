using UnityEngine;

namespace FSMTest
{
    public class WeaponOverheatedState : AState
    {
        private float timer = 0;
        private float overHeatCoolDown;
        public override void Start(IStateRunner runner)
        {
            overHeatCoolDown = runner.SharedData.Get<float>("OverHeatCoolDown");
        }

        public override void Update(IStateRunner runner)
        {
            timer += Time.deltaTime;

            if (timer > overHeatCoolDown)
            {
                Debug.Log("Weapon Cooleddown");
                onSwitch(new WeaponIdleState());
            }
        }
    }

}