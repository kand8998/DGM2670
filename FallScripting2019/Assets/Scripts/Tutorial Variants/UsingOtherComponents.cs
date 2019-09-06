using UnityEngine;
using Debug = System.Diagnostics.Debug;

namespace Tutorial_Variants
{
    public class UsingOtherComponents : MonoBehaviour
    {
        //Unity Tutorial Variant;
        public GameObject otherGameObject;
        private PlayerDeathsIntReference _playerDeathsIntReference;
   
    
        private void Awake()
        {
            _playerDeathsIntReference = GetComponent<PlayerDeathsIntReference>();
        }

        private void OnMouseDown()
        {
            Debug.Write("The player score is{_playerDeathsIntReference.playerScore}");
            Debug.Write("The player has died" + _playerDeathsIntReference.numberOfPlayerDeaths + "times");
        }
    
    }
}
