using System.Collections;
using UnityEngine;
[RequireComponent(typeof(CharacterController))]
public class ACharacterBehaviour : MonoBehaviour
{
    
    public bool canMove = true;
    public CharacterBase character;
    
    private WaitForFixedUpdate wffuObj;
    private CharacterController controller;

    private void Awake()
    {
        controller = GetComponent<CharacterController>();
        character.Controller = controller;
    }

    IEnumerator Start()
    {
        while (canMove)
        {
            character.Move();
            yield return wffuObj;
        }
    }
}
