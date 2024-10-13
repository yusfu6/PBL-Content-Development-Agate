using UnityEngine;

public class DestroyTimerOnTrigger : MonoBehaviour
{
    // Referensi ke UI Timer yang akan dihancurkan
    public GameObject timerPrefab;

    private void OnTriggerEnter(Collider other)
    {
        // Cek apakah objek yang masuk ke trigger adalah player dengan tag "Vehicle"
        if (other.CompareTag("Vehicle"))
        {
            Debug.Log("Vehicle Triggered the Collider!");

            // Jika Timer ada di scene, hancurkan Timer prefab
            if (timerPrefab != null)
            {
                Destroy(timerPrefab);
                Debug.Log("Timer Destroyed");
            }
            else
            {
                Debug.LogWarning("Timer Prefab is not assigned or is null!");
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
