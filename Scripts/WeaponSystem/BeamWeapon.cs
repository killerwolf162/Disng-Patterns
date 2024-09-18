using FSMTest;
using UnityEngine;

public class BeamWeapon : Weapon, IStateRunner
{
    public float chargeTime = 3;
    public float overHeatCoolDown = 3;
    public float beamUpTime = 5;
    public float timeToOverHeat = 6;

    public ScratchPad SharedData => sharedPad;

    private ScratchPad sharedPad;
    private StateMachine stateMachine;

    private void Start()
    {
        sharedPad = new ScratchPad();
        sharedPad.Set<float>("ChargeTime", chargeTime);
        sharedPad.Set<float>("TimeToOverHeat", timeToOverHeat);
        sharedPad.Set<float>("OverHeatCoolDown", overHeatCoolDown);
        sharedPad.Set<float>("BeamUpTime", beamUpTime);

        stateMachine = new StateMachine(this);

        stateMachine.SetState(new WeaponIdleState());
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
