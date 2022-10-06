using UnityEngine;

public class MeleeEntryState : State
{
    public override void OnEnter(StateMachine _stateMachine)
    {
        base.OnEnter(_stateMachine);

        State nextState = new GroundEntryState();
        stateMachine.SetNextState(nextState);
    }
}