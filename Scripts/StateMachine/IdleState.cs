using UnityEngine;

namespace FSMTest
{
    public class IdleState : AState
    {
        public override void Start(IStateRunner runner)
        {
            Debug.Log("IDLE");
        }

        public override void Update(IStateRunner runner)
        {
            if(Input.anyKeyDown)
            {
                onSwitch(new MoveState());
            }
                
        }
    }

}