using UnityEngine;
using UnityEngine.Events;

namespace Tutorial_Variants
{
    public class EnableComponents : MonoBehaviour
    {
        // Unity tutorial variant
        
        public UnityEvent enableEvent;

        private void Update()
        {
            if (Input.GetKeyUp(KeyCode.Space))
            {
                KeyPress();
            }
        }

        private void KeyPress()
        {
            enableEvent.Invoke();
        }
    }
}
