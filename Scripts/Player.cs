using FSMTest;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour, IStateRunner
{
    public ScratchPad SharedData => sharedPad;

    private ScratchPad sharedPad;
    private Rigidbody rigidbody;
    private StateMachine stateMachine;

    private void Start()
    {
        sharedPad = new ScratchPad();
        sharedPad.Set<Rigidbody>("rigidBody", GetComponent<Rigidbody>());

        stateMachine = new StateMachine(this);

        stateMachine.SetState(new IdleState());
    }

    private void Update()
    {
        stateMachine.Update();
    }

    private void FixedUpdate()
    {
        stateMachine.FixedUpdate();
    }

}
