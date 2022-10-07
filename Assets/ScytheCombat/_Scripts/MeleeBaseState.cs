using System;
using System.Collections.Generic;
using UnityEngine;

public class MeleeBaseState : State
{
    public float duration;
    
    protected Animator animator;
    protected bool shouldCombo;
    protected int attackIndex;

    protected Collider hitCollider;
    private List<Collider> _collidersDamaged;
    private GameObject _hitEffectPrefab;
    private float _attackPressedTimer = 0;
    
    public override void OnEnter(StateMachine _stateMachine)
    {
        base.OnEnter(_stateMachine);
        animator = GetComponent<Animator>();
        _collidersDamaged = new List<Collider>();
        hitCollider = GetComponent<ComboCharacter>().hitbox;
        _hitEffectPrefab = GetComponent<ComboCharacter>().hiteffect;
    }

    public override void OnUpdate()
    {
        base.OnUpdate();
        _attackPressedTimer -= Time.deltaTime;

        Debug.Log("before");
        
        if (animator.GetFloat("Weapon.Active") > 0f)
        {
            Debug.Log("1");
            Attack();
        }

        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("2");
            _attackPressedTimer = 2;
        }
        
        if (animator.GetFloat("AttackWindow.Open") > 0f && _attackPressedTimer > 0f)
        {
            Debug.Log("3");
            shouldCombo = true;
        }
    }

    protected void Attack()
    {
        // TODO
        // write method do make dmg
    }
    
    public override void OnExit()
    {
        base.OnExit();
    }
    
}