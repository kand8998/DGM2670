using UnityEngine;
using UnityEngine.UI;
[RequireComponent(typeof(Image))]
public class ImageController : MonoBehaviour
{
    public GameAction imageAction;
    private Image imageComponent;
    public FloatData data;
    private void Start()
    {
        imageComponent = GetComponent<Image>();
        imageAction.action = UpdateImageHandler;
    }

    public void UpdateImageHandler()
    {
        imageComponent.fillAmount = data.value;
    }

    public void UpdateImageComponent(FloatData dataObj)
    {
        imageComponent.fillAmount = dataObj.value;
    }
}
