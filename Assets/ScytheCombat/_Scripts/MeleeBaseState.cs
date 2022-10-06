using System;
using UnityEngine;

public class MeleeBaseState : State
{
    public float duration;
    
    protected Animator animator;
    protected bool shouldCombo;
    protected int attackIndex;

    public override void OnEnter(StateMachine _stateMachine)
    {
        base.OnEnter(_stateMachine);
        animator = GetComponent<Animator>();
    }

    public override void OnUpdate()
    {
        base.OnUpdate();

        if (Input.GetMouseButtonDown(0))
        {
            shouldCombo = true;
        }
    }

    public override void OnExit()
    {
        base.OnExit();
    }
    
}