using UnityEngine;

/// <summary>
/// Gestiona la recolección del Energy Core.
/// Al tocarlo ECHO-07 completa el objetivo del laboratorio.
/// </summary>
public class EnergyCore : MonoBehaviour
{
    [Header("Mission Feedback")]
    [SerializeField] private GameObject missionCompleteText;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log(
                "ENERGY CORE RECOVERED - ESCAPE PROTOCOL COMPLETE"
            );

            // Mostramos feedback visual de misión completada.
            if (missionCompleteText != null)
            {
                missionCompleteText.SetActive(true);
            }

            // Eliminamos el núcleo junto con sus efectos visuales.
            Destroy(gameObject);
        }
    }
}