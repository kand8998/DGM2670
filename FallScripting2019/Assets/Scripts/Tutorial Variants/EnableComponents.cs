using UnityEngine;

namespace Tutorial_Variants
{
    public class EnableComponents : MonoBehaviour
    {
        // Unity turotial variant
        private Light spotLight;
        private void Start()
        {
            spotLight = GetComponent<Light>();
        }
    
        private void Update()
        {
            if (Input.GetKeyUp(KeyCode.Space))
            {
                spotLight.enabled = false;
            }
        }
    }
}
