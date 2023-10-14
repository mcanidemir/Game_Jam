using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvantereKoy : MonoBehaviour
{
    public GameObject Meyve;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Meyve"))
        {
            Meyve.SetActive(true);
        }
    }
}
