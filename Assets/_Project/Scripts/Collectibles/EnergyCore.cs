using UnityEngine;

/// <summary>
/// Energy Core que desaparece cuando ECHO-07 lo recoge.
/// </summary>
public class EnergyCore : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("ENERGY CORE RECOVERED - ESCAPE PROTOCOL COMPLETE");

            Destroy(gameObject);
        }
    }
}