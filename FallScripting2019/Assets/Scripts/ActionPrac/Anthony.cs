using UnityEngine;

public class Anthony : MonoBehaviour
{
    public GameAction gameActionObj;

    public void Yell()
    {
        Debug.Log("Anthony");
    }

    private void Awake()
    {
        
    }

    void Start()
    {
        gameActionObj.Raise();
    }
}
