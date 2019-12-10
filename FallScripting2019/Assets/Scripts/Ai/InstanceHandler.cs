using UnityEngine;
using UnityEngine.Events;

public class InstanceHandler: MonoBehaviour
{
    public GameAction instantiateAction;
    public GameObject instanceObj;
    public Transform location;
    
    

    private void Start()
    {
        instantiateAction.action += Instantiate;
    }
    
    private void Instantiate()
    {
        Instantiate(instanceObj, location.position,
            location.rotation);
    }

}
