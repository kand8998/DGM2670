using UnityEngine;

namespace Tutorial_Variants
{
    public class AxisExampleHorizontalVertical : MonoBehaviour
    {
        // Unity Tutorial Variant
        public float hRange;
        public float vRange;
        public void Update()
        {
            var h = Input.GetAxis("Horizontal");
            var v = Input.GetAxis("Vertical");
            var xPos = h * hRange;
            var vPos = v * vRange;

            transform.position = new Vector3(xPos, 0, vPos);
        }
    }
}
