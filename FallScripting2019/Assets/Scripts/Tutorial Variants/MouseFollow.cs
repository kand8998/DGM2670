using UnityEngine;
using UnityEngine.Experimental.UIElements;

namespace Tutorial_Variants
{
    public class MouseFollow : MonoBehaviour
    {
        // Tutorial Variant

        private void Update()
        {
            CursorTrail();
     
        }

        public void CursorTrail()
        {
            Vector3 cursorPos = Camera.main.ScreenToViewportPoint(Input.mousePosition);
            transform.position = cursorPos;
        }
    }
}
