using System.Collections;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class ACharacterBehaviour : MonoBehaviour
{
    public bool canMove = true;
    public CharacterBase character;
    
    private CharacterController controller;
    private WaitForFixedUpdate wffuObj;
    
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
