using UnityEngine;

public class ArrowTrigger : MonoBehaviour
{
    private ArrowSequenceManager manager;

    void Start()
    {
        // Busca el manager en el objeto padre
        manager = GetComponentInParent<ArrowSequenceManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Asegúrate de que el jugador tenga la etiqueta "Player"
        {
            manager.ActivateNextArrow(); // Notifica al manager para activar la siguiente flecha
        }
    }
}
