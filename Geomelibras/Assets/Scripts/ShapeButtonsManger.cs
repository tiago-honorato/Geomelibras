using UnityEngine;

public class ShapeButtonsManger : MonoBehaviour
{
    private ShapeButtons primeiroClique;
    private ShapeButtons segundoClique;

    public PointsManager PointsManager;

    public GameObject Line1;
    public GameObject Line2;
    public GameObject Line3;
    public GameObject Line4;
    public GameObject Line5;
    public GameObject Line6;

    public void ReceberClique(ShapeButtons botao)
    {

        if (botao == primeiroClique)
            return;

        if (primeiroClique == null)
        {
            primeiroClique = botao;
            return;
        }

        segundoClique = botao;

        VerificarIDs();

        primeiroClique = null;
        segundoClique = null;
    }

    void VerificarIDs()
    {

        if (primeiroClique.id == 1 && segundoClique.id == 1)
        {
            Line1.SetActive(true);
            Debug.Log("Ligação correta!");
            PointsManager.AddCount();
        }
        else
        {
            Debug.Log("Ligação errada!");
        }

        if (primeiroClique.id == 2 && segundoClique.id == 2)
        {
            Line2.SetActive(true);
            Debug.Log("Ligação correta!");
            PointsManager.AddCount();
        }
        else
        {
            Debug.Log("Ligação errada!");
        }

        if (primeiroClique.id == 3 && segundoClique.id == 3)
        {
            Line3.SetActive(true);
            Debug.Log("Ligação correta!");
            PointsManager.AddCount();
        }
        else
        {
            Debug.Log("Ligação errada!");
        }

        if (primeiroClique.id == 4 && segundoClique.id == 4)
        {
            Line4.SetActive(true);
            Debug.Log("Ligação correta!");
            PointsManager.AddCount();
        }
        else
        {
            Debug.Log("Ligação errada!");
        }

        if (primeiroClique.id == 5 && segundoClique.id == 5)
        {
            Line5.SetActive(true);
            Debug.Log("Ligação correta!");
            PointsManager.AddCount();
        }
        else
        {
            Debug.Log("Ligação errada!");
        }

        if (primeiroClique.id == 6 && segundoClique.id == 6)
        {
            Line6.SetActive(true);
            Debug.Log("Ligação correta!");
            PointsManager.AddCount();
        }
        else
        {
            Debug.Log("Ligação errada!");
        }

    }
}