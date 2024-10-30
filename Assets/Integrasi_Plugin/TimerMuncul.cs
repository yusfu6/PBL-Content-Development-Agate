using UnityEngine;
using UnityEngine.UI;

public class TimerMuncul : MonoBehaviour
{
    public GameObject timerPrefab; // Prefab UI Timer yang akan dipanggil
    public Transform canvasTransform; // Transform Canvas untuk tempat spawn UI
    private bool hasSpawnedTimer = false; // Flag untuk mengecek apakah Timer sudah di-spawn

    public static GameObject activeTimerUI; // Referensi static untuk Timer yang aktif

    private void OnTriggerEnter(Collider other)
    {
        // Cek apakah objek yang masuk ke trigger adalah player dengan tag "Vehicle"
        if (other.CompareTag("Vehicle"))
        {
            if (!hasSpawnedTimer)
            {
                // Memanggil fungsi untuk spawn Timer pertama kali
                SpawnTimer();
                hasSpawnedTimer = true; // Menandai bahwa Timer sudah di-spawn
            }
            else
            {
                // Jika sudah spawn, destroy BoxCollider di objek ini
                Destroy(GetComponent<BoxCollider>());
            }
        }
    }

    private void SpawnTimer()
    {
        // Membuat UI Timer di dalam Canvas
        activeTimerUI = Instantiate(timerPrefab, canvasTransform);

        // Pastikan timer muncul di Canvas (posisi di tengah atau sesuai kebutuhan)
        activeTimerUI.GetComponent<RectTransform>().anchoredPosition = Vector2.zero;

        // Mengatur timer jika ada komponen Timer script di prefab
        Timer timerComponent = activeTimerUI.GetComponent<Timer>();
    }
}