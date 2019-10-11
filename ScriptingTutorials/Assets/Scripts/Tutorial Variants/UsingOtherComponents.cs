using UnityEngine;
using Debug = System.Diagnostics.Debug;

namespace Tutorial_Variants
{
    public class UsingOtherComponents : MonoBehaviour
    {
        //Unity Tutorial Variant;
        public GameObject otherGameObject;
        private PlayerDeathsIntReference playerDeathsIntReference;
   
    
        private void Awake()
        {
            playerDeathsIntReference = GetComponent<PlayerDeathsIntReference>();
        }

        private void OnMouseDown()
        {
            Debug.Write("The player score is{playerDeathsIntReference.playerScore}");
            Debug.Write("The player has died" + playerDeathsIntReference.numberOfPlayerDeaths + "times");
        }
    
    }
}
