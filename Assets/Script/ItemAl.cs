using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemAl : MonoBehaviour
{
    private bool Area =false;
    private void Update()
    {
        if ( Area && Input.GetKey(KeyCode.E))
        {
            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Area = true;
        }
        else
        {
            Area = false;
        }
    }
}
