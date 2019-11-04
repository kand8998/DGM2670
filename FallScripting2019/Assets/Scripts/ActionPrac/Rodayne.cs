using UnityEngine;

public class Rodayne : MonoBehaviour
{
    public GameAction gameActionObj;
    
    public void Talk()
    {
        Debug.Log("Rodayne");
    }

    private void Awake()
    {
        gameActionObj.action += Talk;
    }

    void Start()
    {

    }
    
}
