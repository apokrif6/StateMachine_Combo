using System;
using UnityEngine;

public class StateMachine: MonoBehaviour
{
    public string customName;
    
    public State currentState;

    private State _nextState;
    private State _mainState;

    private void Awake()
    {
        SetNextStateToMain();
    }

    private void OnValidate()
    {
        if (_mainState != null) return;
        
        if (customName == "Combat")
        {
            _mainState = new IdleCombatState();
        }
    }
    
    public void SetNextStateToMain()
    {
        _nextState = _mainState;
    }
    
    private void FixedUpdate()
    {
        currentState?.OnFixedUpdate();
    }
    
    public void Update()
    {
        if (_nextState != null)
        {
            SetState(_nextState);
        }

        currentState?.OnUpdate();
    }

    private void SetState(State newState)
    {
        _nextState = null;

        currentState?.OnExit();

        currentState = newState;
        currentState.OnEnter(this);
    }
    
    public void SetNextState(State newState)
    {
        if (newState != null)
        {
            _nextState = newState;
        }
    }
}