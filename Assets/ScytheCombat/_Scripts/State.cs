using UnityEngine;

public abstract class State
{
    protected StateMachine stateMachine;
    
    protected float Fixedtime { get; set; }

    
    public virtual void OnEnter(StateMachine _stateMachine)
    {
        stateMachine = _stateMachine;
    }

    public virtual void OnUpdate()
    {
        
    }

    public void OnFixedUpdate()
    {
        Fixedtime += Time.deltaTime;
    }

    public virtual void OnExit()
    {
        
    }
    
    #region Passthrough Methods
    static void Destroy(UnityEngine.Object obj)
    {
        UnityEngine.Object.Destroy(obj);
    }
    protected T GetComponent<T>() where T : Component { return stateMachine.GetComponent<T>(); }
    
    protected Component GetComponent(System.Type type) { return stateMachine.GetComponent(type); }

 
    protected Component GetComponent(string type) { return stateMachine.GetComponent(type); }
    #endregion
}