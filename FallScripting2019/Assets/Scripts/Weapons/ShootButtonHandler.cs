using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
[RequireComponent(typeof(Image))]
[RequireComponent(typeof(Text))]
public class ShootButtonHandler : MonoBehaviour
{
    public ShootConfig shootObj;
    private Button weaponButton;
    private Image buttonImg;
    private Text buttonText;
    private void Start()
    {
        weaponButton = GetComponent<Button>();
        weaponButton.onClick.AddListener(shootObj.RaiseFireAction);
        buttonImg = GetComponent<Image>();
        buttonImg.color = shootObj.weaponColor;
        buttonText = GetComponentInChildren<Text>();
        buttonText.text = shootObj.name + " Fire";
        shootObj.collectWeaponAction = OnCollectWeapon;
        weaponButton.interactable = true;
    }

    public void OnCollectWeapon()
    {
        weaponButton.interactable = true;
    }
}
