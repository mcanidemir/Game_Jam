using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TutorialTimer : MonoBehaviour
{
    

    // Update is called once per frame
    void Update()
    {
         

        if(Time.realtimeSinceStartup>30)
        {
            SceneManager.LoadScene("Currenttime");
        }
    }
}
