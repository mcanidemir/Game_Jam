using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public GameObject verypast;
    public GameObject past;
    public GameObject future;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            verypast.SetActive(true);
            past.SetActive(false);
            future.SetActive(false);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            past.SetActive(true);
            verypast.SetActive(false);
            future.SetActive(false);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            past.SetActive(false);
            verypast.SetActive(false);
            future.SetActive(true);
        }
    }

}
