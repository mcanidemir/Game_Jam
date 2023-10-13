using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Zoom : MonoBehaviour
{
    public CinemachineVirtualCamera far;
    public CinemachineVirtualCamera close;
    public GameObject Player;
    public GameObject GameObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            CloseUp();
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            FarAway();
        }
    }
    public void FarAway()
    {
        far.m_Priority = 15;
        close.m_Priority = 10;
    }
    public void CloseUp()
    {
        far.m_Priority = 10;
        close.m_Priority = 15;
    }
}
