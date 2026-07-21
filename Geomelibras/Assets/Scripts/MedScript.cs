using UnityEngine;
using UnityEngine.UI;

public class MedScript : MonoBehaviour
{
    public Image botaoImage;

    public GameObject NextLevelButton;

    public Button ShapeButton;

    public void Correct()
    {
        if (botaoImage != null)
        {

            botaoImage.color = Color.green;

        }
    }

    public void Incorrect()
    {
        if (botaoImage != null)
        {
            botaoImage.color = Color.red;
        }
    }

    public void LockButton()
    {

        ShapeButton.interactable = false;

    }
}