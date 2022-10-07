using UnityEngine;

public class GroundComboState: MeleeBaseState
{
    public override void OnEnter(StateMachine _stateMachine)
    {
        base.OnEnter(_stateMachine  );
        
        attackIndex = 2;
        duration = 0.5f;
        animator.SetTrigger("Attack" + attackIndex);
        
        Debug.Log("Player Attack " + attackIndex + " Fired!");
    }
    
    public override void OnUpdate()
    {
        base.OnUpdate();

        if (Fixedtime >= duration)
        {
            if (shouldCombo)
            {
                stateMachine.SetNextState(new GroundFinisherState());
            }
            else
            {
                stateMachine.SetNextStateToMain();
            }
        }
    }
}
