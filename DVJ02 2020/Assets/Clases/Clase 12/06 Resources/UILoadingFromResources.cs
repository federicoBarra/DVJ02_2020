using UnityEngine;
using UnityEngine.UI;

namespace DVJ02.Clase12
{
public class UILoadingFromResources : MonoBehaviour
{
    public Image image;

    public void LoadImage()
    {
        Sprite sprite = Resources.Load<Sprite>("spriteRes");
        image.sprite = sprite;
    }
}
}