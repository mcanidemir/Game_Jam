using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject s1;
    public GameObject s2;

    // Update is called once per frame
    void Update()
    {
        if (Time.realtimeSinceStartup <= 7)
        {
            s1.SetActive(true);
            s2.SetActive(false);
        }
      
        else if (Time.realtimeSinceStartup <= 15)
        {
            s2.SetActive(true);
            s1.SetActive(false);
        }

        else
        {
            SceneManager.LoadScene("HowToPlay");
        }
        
    }
}
