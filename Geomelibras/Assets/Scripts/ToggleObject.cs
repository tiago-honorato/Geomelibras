using UnityEngine;

public class ToggleObject : MonoBehaviour
{

    public GameObject G_object;

    public GameObject G_object2;

    //Ativa e desativa.
    public void ToggleObj()
    {
        if (G_object != null)
        {
            G_object.SetActive(!G_object.activeSelf);
        }
    }

    public void ToggleTwoObj()
    {
        if (G_object != null)
        {
            G_object.SetActive(!G_object.activeSelf);
            if (G_object2 != null && G_object2.activeSelf)
            {
                G_object2.SetActive(false);
            }
        }
    }

}
