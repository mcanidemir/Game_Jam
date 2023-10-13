using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public GameObject verypast;
    public GameObject past;
    public GameObject future;
    public GameObject verypastfloor;
    public GameObject pastfloor;
    public GameObject futurefloor;

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
            verypastfloor.SetActive(true);
            pastfloor.SetActive(false);
            futurefloor.SetActive(false);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            past.SetActive(true);
            verypast.SetActive(false);
            future.SetActive(false);
            verypastfloor.SetActive(false);
            pastfloor.SetActive(true);
            futurefloor.SetActive(false);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            past.SetActive(false);
            verypast.SetActive(false);
            future.SetActive(true);
            verypastfloor.SetActive(false);
            pastfloor.SetActive(false);
            futurefloor.SetActive(true);
        }
    }

}
