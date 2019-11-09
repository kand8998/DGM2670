using UnityEngine;

public class DestoryObj : MonoBehaviour
{
    public GameObject destroyableObj;
    private void Start()
    {
        Destroy(destroyableObj, 3.5f);
    }
}
