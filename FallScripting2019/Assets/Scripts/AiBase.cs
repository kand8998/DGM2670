using UnityEngine;
using UnityEngine.AI;

//Script Based on Professor's Method
public abstract class AiBase : ScriptableObject, AiBase.IAi
{
    public AiBase Speed;
    public AiBase AngularSpeed;
    public abstract void Navigate(NavMeshAgent ai);
    
    public interface IAi
    {
        
    }
}
