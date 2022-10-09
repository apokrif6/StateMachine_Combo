using System;
using System.Collections.Generic;
using UnityEngine;

public class MeleeBaseState : State
{
    public float duration;
    
    protected Animator animator;
    protected bool shouldCombo;
    protected int attackIndex;
    
    private float _attackPressedTimer;
    
    public override void OnEnter(StateMachine _stateMachine)
    {
        base.OnEnter(_stateMachine);
        animator = GetComponent<Animator>();
    }

    public override void OnUpdate()
    {
        base.OnUpdate();
        _attackPressedTimer -= Time.deltaTime;
        
        if (animator.GetFloat("Weapon.Active") > 0f)
        {
            Attack();
        }

        if (Input.GetMouseButtonDown(0))
        {
            _attackPressedTimer = 3f;
        }
        
        if (animator.GetFloat("AttackWindow.Open") > 0f && _attackPressedTimer > 0f)
        {
            shouldCombo = true;
        }
    }

    private void Attack()
    {
        // TODO
        // write method do make dmg
    }
    
    public override void OnExit()
    {
        base.OnExit();
    }
    
}