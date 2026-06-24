using UnityEngine;
using UnityEngine.UI;

public class HardScript : MonoBehaviour
{
    public Image botaoImage;

    public GameObject NextButton;

    public Button ShapeButton;

    public void Correct()
    {
        if (botaoImage != null)
        {
            botaoImage.color = Color.green;
            NextButton.SetActive(true);
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