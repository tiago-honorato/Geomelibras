using UnityEngine;

public class PointsManager : MonoBehaviour
{

    public int CorrectCount;

    public GameObject NextLevelButton;

    public void AddCount()
    {
        CorrectCount++;
    }

    public void UnlockNextLevelButton()
    {

        if (CorrectCount >= 4)
        {
            NextLevelButton.SetActive(true);
        }

    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        UnlockNextLevelButton();
    }
}
