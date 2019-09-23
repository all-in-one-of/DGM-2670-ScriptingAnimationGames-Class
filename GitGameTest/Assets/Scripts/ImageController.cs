using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class ImageController : MonoBehaviour
{
    private Image imageComponent;

    // Start is called before the first frame update
    private void Start()
    {
        imageComponent = GetComponent<Image>();
    }

    public void UpdateImageComponent(float amount)
    {
        imageComponent.fillAmount += amount;
    }
    
    public void UpdateImageComponent(FloatData dataObj)
    {
        imageComponent.fillAmount = dataObj.value;
    }
    
}
