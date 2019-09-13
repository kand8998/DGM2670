using UnityEngine;

namespace Tutorial_Variants
{
    public class TransformFunctions : MonoBehaviour
    {
        // Unity tutorial variant
        public float moveSpeed = 10f;
        private void Start()
        {
            transform.Translate(new Vector3(0,0,1));
            transform.Rotate(new Vector3(1,0,0));
        }

        private void Update()
        {
            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.Translate(moveSpeed * Time.deltaTime * Vector3.forward);
            }
        }
    }
}
