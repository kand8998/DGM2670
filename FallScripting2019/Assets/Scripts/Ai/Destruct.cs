using UnityEngine;
using UnityEngine.Events;

public class Destruct : MonoBehaviour
{
    public float destructTime = 3f;
    public GameAction destroyAction;

    private void Start()
    {
        destroyAction.action += DestroyObject;
    }

    private void DestroyObject()
    {
        Destroy(gameObject, destructTime + 0.1f);
    }
}
