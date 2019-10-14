using System;
using UnityEngine;


public class CreateSOData : MonoBehaviour
{
    public IntData data;
    private IntData newData;
    private void Start()
    {
        newData = Instantiate(data);
    }
    
}
