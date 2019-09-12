using UnityEngine;

public class ProjectileDestruction : MonoBehaviour
{
    // Unity Tutorial Variant
    private void Start()
    {
        Destroy(gameObject, 3.5f);
    }
}
