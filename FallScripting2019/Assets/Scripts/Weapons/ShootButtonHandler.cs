using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
[RequireComponent(typeof(Image))]
public class ShootButtonHandler : MonoBehaviour
{
    public ShootConfig shootObj;
    private Button weaponButton;
    private Image buttonImg;
    private void Start()
    {
        weaponButton = GetComponent<Button>();
        weaponButton.onClick.AddListener(shootObj.RaiseShootAction);
        buttonImg = GetComponent<Image>();
        weaponButton.interactable = true;
    }
}
