using UnityEngine;

namespace Tutorial_Variants
{
    public class GetAxis : MonoBehaviour
    {
        
        public float hRange;
        public float vRange;
        public void Update()
        {
           GetAxisHorizAndVert();
        }

        private void GetAxisHorizAndVert()
        {
            var h = Input.GetAxis("Horizontal");
            var v = Input.GetAxis("Vertical");
            var xPos = h * hRange;
            var vPos = v * vRange;
            
            transform.position = new Vector3(xPos, 0, vPos);
        }
    }
}
