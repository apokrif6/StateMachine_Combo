using System;
using UnityEngine;

public class ComboCharacter: MonoBehaviour
{
    private StateMachine _stateMachine;

    [SerializeField] public Collider hitbox;

    private void Start()
    {
        Debug.Log(GetComponent<StateMachine>());

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
