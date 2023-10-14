using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLocation : MonoBehaviour
{
    // Start is called before the first frame update
    void Update()
    {

        Vector3 mousePosition = Input.mousePosition;


        mousePosition = Camera.main.ScreenToWorldPoint(new Vector3(mousePosition.x, mousePosition.y, 20));


        transform.position = mousePosition;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("A");
    }
}
