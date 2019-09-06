using UnityEngine;

namespace Tutorial_Variants
{
    public class UpdateAndFixedUpdate : MonoBehaviour
    {
        // Unity Tutorial Variant
        private float fixedUpdateTimer;
        private float UpdateTimer;

        private void fixedUpdate()
        {
            Debug.Log("FixedUpdate time:" + Time.deltaTime);
        }

        private void Update()
        {
            Debug.Log("Update time:" + Time.deltaTime);
        }
    }
}
