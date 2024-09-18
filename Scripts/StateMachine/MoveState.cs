using UnityEngine;

namespace FSMTest
{
    public class MoveState : AState
    {

        Rigidbody rigidBody;
        public override void Start(IStateRunner runner)
        {
            rigidBody = runner.SharedData.Get<Rigidbody>("rigidBody");
            Debug.Log("Move");
        }

        public override void Update(IStateRunner runner)
        {
            if(Input.GetKey(KeyCode.A))
            {
                Debug.Log("add force left");
                rigidBody.AddForce(new Vector3(-10,0,0), ForceMode.Acceleration);
            }
            if (Input.GetKey(KeyCode.W))
            {
                Debug.Log("add force left");
                rigidBody.AddForce(new Vector3(0, 0, 10), ForceMode.Acceleration);
            }
            if (Input.GetKey(KeyCode.S))
            {
                Debug.Log("add force left");
                rigidBody.AddForce(new Vector3(0, 0, -10), ForceMode.Acceleration);
            }
            if (Input.GetKey(KeyCode.D))
            {
                Debug.Log("add force left");
                rigidBody.AddForce(new Vector3(10, 0, 0), ForceMode.Acceleration);
            }


            // if player speed > 0, also implement drag force

            //if(rigidBody.velocity.magnitude <= 0)
            //{
            //    onSwitch(new IdleState());
            //}
        }

        public override void Complete(IStateRunner runner)
        {
            // when no player input return to Idle State
        }
    }

}