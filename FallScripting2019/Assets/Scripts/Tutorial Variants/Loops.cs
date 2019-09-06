using UnityEngine;
using UnityEngine.Events;


public class Loops : MonoBehaviour
{
    // Unity Tutorial Variant and Testing

    private int eggsInTheBasket = 12;
    public UnityEvent ContinueEvent;
    private int numEnemies = 3;

    private void Start()
    {
        while (eggsInTheBasket > 0)
        {
            Debug.Log("We have eggs!");
            eggsInTheBasket--;
        }

        bool shouldContinue = false;

        do
        {
            ContinueEvent.Invoke();
        } while (shouldContinue == true);

        for (int i = 0; i < numEnemies; i++)
        {
            Debug.Log("Creating enemy number: " + i);
        }
    }
    
}
