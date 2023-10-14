using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Plant : MonoBehaviour
{
    public GameObject Meyve;
    public GameObject Fidan;
    private bool PlantArea;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PlantArea && Input.GetKey(KeyCode.E))
        {
            Meyve.SetActive(false);
            Fidan.SetActive(true);
        }
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            PlantArea = true;
        }
        else
        {
            PlantArea = false;
        }
    }
}
