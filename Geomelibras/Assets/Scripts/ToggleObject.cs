using UnityEngine;

public class ToggleObject : MonoBehaviour // CODIGO PODRE ABAIXO
{

    public GameObject G_object;

    public GameObject G_object2;

    public void ToggleSelectedObj(GameObject obj)
    {
        if (obj != null)
        {
            obj.SetActive(!obj.activeSelf);
        }
    }

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
