using UnityEngine;

public class Tujuan : MonoBehaviour
{
    public GameObject cubePrefab; // Prefab kubus yang akan dipanggil
    public Transform spawnTransform; // Transform untuk menentukan posisi spawn
    private bool hasSpawnedCube = false; // Flag untuk mengecek apakah kubus sudah di-spawn

    private void OnTriggerEnter(Collider other)
    {
        // Cek apakah objek yang masuk ke trigger adalah player dengan tag "Vehicle"
        if (other.CompareTag("Vehicle"))
        {
            if (!hasSpawnedCube)
            {
                // Memanggil fungsi untuk spawn kubus pertama kali
                SpawnCube();
                hasSpawnedCube = true; // Menandai bahwa kubus sudah di-spawn
            }
            else
            {
                // Jika sudah spawn, destroy BoxCollider di objek ini
                Destroy(GetComponent<BoxCollider>());
            }
        }
    }

    private void SpawnCube()
    {
        // Menggunakan transform untuk menentukan posisi spawn
        Vector3 spawnPosition = spawnTransform.position;

        // Membuat kubus baru
        Instantiate(cubePrefab, spawnPosition, Quaternion.identity);
    }
}
