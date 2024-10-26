using UnityEngine;

public class HapusTimer : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // Cek apakah objek yang masuk ke trigger adalah player dengan tag "Vehicle"
        if (other.CompareTag("Vehicle"))
        {
            Debug.Log("Vehicle Triggered the Collider!");

            // Jika Timer sudah di-spawn oleh script TimerMuncul, hancurkan timer
            if (TimerMuncul.activeTimerUI != null)
            {
                Destroy(TimerMuncul.activeTimerUI);
                TimerMuncul.activeTimerUI = null; // Set referensi ke null setelah dihancurkan
                Debug.Log("Timer Destroyed");
            }
            else
            {
                Debug.LogWarning("Timer is not active or has already been destroyed!");
            }

            // Hancurkan BoxCollider dari objek ini juga jika diperlukan
            Destroy(GetComponent<BoxCollider>());
            Debug.Log("BoxCollider Destroyed");
        }
        else
        {
            Debug.Log("Collider triggered by an object without the 'Vehicle' tag.");
        }
    }
}