using UnityEngine;

public class ArrowSequenceManager : MonoBehaviour
{
    private int currentArrowIndex = 0; // Índice de la flecha activa
    public AudioClip arrowSound; // Clip de sonido para las flechas
    private AudioSource audioSource; // Referencia al AudioSource

    void Start()
    {
        // Obtener el componente AudioSource
        audioSource = GetComponent<AudioSource>();

        // Desactivar todas las flechas excepto la primera
        for (int i = 0; i < transform.childCount; i++)
        {
            transform.GetChild(i).gameObject.SetActive(i == 0);
        }
    }

    public void ActivateNextArrow()
    {
        // Desactivar la flecha actual
        if (currentArrowIndex < transform.childCount)
        {
            transform.GetChild(currentArrowIndex).gameObject.SetActive(false);
        }

        // Reproducir el sonido
        if (arrowSound != null)
        {
            audioSource.PlayOneShot(arrowSound);
        }

        // Activar la siguiente flecha si hay más
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
