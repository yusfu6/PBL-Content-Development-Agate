using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Penumpang : MonoBehaviour
{
    public string vehicleTag = "Vehicle"; // Tag untuk kendaraan

    // Ketika penumpang menyentuh kendaraan
    void OnCollisionEnter(Collision collision)
    {
        // Jika yang disentuh adalah kendaraan
        if (collision.gameObject.CompareTag(vehicleTag))
        {
            // Trigger aksi, misalnya menghancurkan penumpang
            Destroy(gameObject);

            // Atau, bisa melakukan aksi lain seperti menampilkan pesan
            Debug.Log("Penumpang telah berada didalam kendaraan!");
        }
    }
}
