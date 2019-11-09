using UnityEngine;

public class DestoryObj : MonoBehaviour
{
    public GameObject destroyableObj;
    public float value;
    private void Start()
    {
        Destroy(destroyableObj, value);
    }
}