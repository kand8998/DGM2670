using UnityEngine;

namespace Tutorial_Variants
{
    public class CameraLookAt : MonoBehaviour
    {
        // Unity Tutorial Variant
        public Transform target;
        private void Update()
        {
            LookAt();
        }

        private void LookAt()
        {
            transform.LookAt(target);
        }
    }
}
