using UnityEngine;

public class ArrowSequenceManager : MonoBehaviour
{
    private int currentArrowIndex = 0; // Índice de la flecha activa

    void Start()
    {
        // Desactiva todas las flechas excepto la primera
        for (int i = 0; i < transform.childCount; i++)
        {
            transform.GetChild(i).gameObject.SetActive(i == 0);
        }
    }

    public void ActivateNextArrow()
    {
        // Desactiva la flecha actual
        if (currentArrowIndex < transform.childCount)
        {
            transform.GetChild(currentArrowIndex).gameObject.SetActive(false);
        }

        // Activa la siguiente flecha si hay más
        currentArrowIndex++;
        if (currentArrowIndex < transform.childCount)
        {
            transform.GetChild(currentArrowIndex).gameObject.SetActive(true);
        }
        else
        {
            Debug.Log("Todas las flechas han sido activadas.");
        }
    }
}
