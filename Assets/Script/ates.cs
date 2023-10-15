using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ates : MonoBehaviour
{
    public GameObject silah;
    public GameObject duvar;
    private bool Area;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Area && Input.GetKey(KeyCode.F) && silah.activeSelf)
        {
            silah.SetActive(false);
            Destroy(duvar);
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Duvar"))
        {
            Area = true;
        }
        else
        {
            Area = false;
        }
    }
}
