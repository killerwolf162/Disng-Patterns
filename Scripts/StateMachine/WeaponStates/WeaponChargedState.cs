using UnityEngine;

namespace FSMTest
{
    public class WeaponChargedState : AState
    {
        private float timer = 0;
        private float timeToOverHeat; 

        public override void Start(IStateRunner runner)
        {
            Debug.Log("Weapon fully charged, fire now!");
            timeToOverHeat = runner.SharedData.Get<float>("TimeToOverHeat");
        }

        public override void Update(IStateRunner runner)
        {
            timer += Time.deltaTime;

            if (Input.GetKey(KeyCode.Mouse0))
            {
                Debug.Log("Fireing beam weapon");
                timer = 0;
                onSwitch(new WeaponFireingState());
            }

            if (timer > timeToOverHeat)
            {
                Debug.Log("Weapon overheated");
                onSwitch(new WeaponOverheatedState());
            }

                  

        }
    }

}