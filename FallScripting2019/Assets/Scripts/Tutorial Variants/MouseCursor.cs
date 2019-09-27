using UnityEngine;
using UnityEngine.Experimental.UIElements;

namespace Tutorial_Variants
{
    public class MouseCursor : MonoBehaviour
    {
        // Tutorial Variant
        
        private void Start() {
        }

        private void Update()
        {
            CursorFollow();
     
        }

        public void CursorFollow()
        {
            Vector2 cursorPos = Camera.main.ScreenToViewportPoint(Input.mousePosition);
            transform.position = cursorPos;
        }
    }
}
