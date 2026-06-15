using UnityEngine;

public class ToggleObject : MonoBehaviour
{

    public GameObject G_object;

    public void ToggleObj()
    {
        if (G_object != null)
        {
            G_object.SetActive(!G_object.activeSelf);
        }
    }

}
