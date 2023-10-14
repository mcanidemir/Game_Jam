using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvantereKoy : MonoBehaviour
{
    public GameObject Meyve;
    private bool Area = false;
    private void Update()
    {
        if (Area && Input.GetKey(KeyCode.E))
        {
            Meyve.SetActive(true);
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Meyve"))
        {
            Area = true;
        }
        else
        {
            Area = false;
        }
    }
}
