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

    /// <summary>
    /// Removes a gameobject, component, or asset.
    /// </summary>
    /// <param name="obj">The type of Component to retrieve.</param>
    protected static void Destroy(UnityEngine.Object obj)
    {
        UnityEngine.Object.Destroy(obj);
    }

    /// <summary>
    /// Returns the component of type T if the game object has one attached, null if it doesn't.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    protected T GetComponent<T>() where T : Component { return stateMachine.GetComponent<T>(); }

    /// <summary>
    /// Returns the component of Type <paramref name="type"/> if the game object has one attached, null if it doesn't.
    /// </summary>
    /// <param name="type">The type of Component to retrieve.</param>
    /// <returns></returns>
    protected Component GetComponent(System.Type type) { return stateMachine.GetComponent(type); }

    /// <summary>
    /// Returns the component with name <paramref name="type"/> if the game object has one attached, null if it doesn't.
    /// </summary>
    /// <param name="type">The type of Component to retrieve.</param>
    /// <returns></returns>
    protected Component GetComponent(string type) { return stateMachine.GetComponent(type); }
    #endregion
}