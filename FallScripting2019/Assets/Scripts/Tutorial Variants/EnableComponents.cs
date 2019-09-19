using UnityEngine;
using UnityEngine.Events;

namespace Tutorial_Variants
{
    public class EnableComponents : MonoBehaviour
    {
        // Unity tutorial variant
        
        public UnityEvent sampleEvent;
        public bool keyUp = Input.GetKeyUp(KeyCode.Space);

        private void Awake()
        {
            sampleEvent.Invoke();
            var keyIn = Input.GetKeyUp(KeyCode.K);
        }
        
    }
}
