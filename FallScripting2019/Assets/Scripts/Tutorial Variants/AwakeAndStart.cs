using UnityEngine;

public class AwakeAndStart : MonoBehaviour
{
    // Unity Tutorial Variant

    private void Awake()
        //References between scripts when game starts
    {
        Debug.Log("I'm Awake");
    }

    private void Start()
        //Begins when made active, only happens once
    {
        Debug.Log("Time to Start the Day!");
    }


}
