using UnityEngine;

public class ShapeButtons : MonoBehaviour
{
    public int id;
    public ShapeButtonsManger manager;

    public void Clicou()
    {
        manager.ReceberClique(this);
    }
}