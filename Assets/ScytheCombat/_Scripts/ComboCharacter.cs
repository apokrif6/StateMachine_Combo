using System;
using UnityEngine;

public class ComboCharacter : MonoBehaviour
{
    private StateMachine _stateMachine;
    private void Start()
    {
        _stateMachine = GetComponent<StateMachine>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && _stateMachine.currentState.GetType() == typeof(IdleCombatState))
        {
            _stateMachine.SetNextState(new GroundEntryState());
        }
    }
}
