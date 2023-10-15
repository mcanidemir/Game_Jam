using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnvantereKoy : MonoBehaviour
{
    public GameObject Meyve;
    public GameObject Silah;
    public GameObject Part_1;
    public GameObject Part_2;
    public GameObject Part_3;

    private bool M_Area = false;
    private bool S_Area = false;
    private bool Area_1 = false;
    private bool Area_2 = false;
    private bool Area_3 = false;
    private void Update()
    {
        #region Meyve
        if (M_Area && Input.GetKey(KeyCode.E))
        {
            Meyve.SetActive(true);
        }
        #endregion
        #region Silah
        if (S_Area && Input.GetKey(KeyCode.E))
        {
            Silah.SetActive(true);
        }
        #endregion
        #region Part_1
        if (Area_1 && Input.GetKey(KeyCode.E))
        {
            Part_1.SetActive(true);
        }
        #endregion
        #region Part_2
        if (Area_2 && Input.GetKey(KeyCode.E))
        {
            Part_2.SetActive(true);
        }
        #endregion
        #region Part_3
        if (Area_3 && Input.GetKey(KeyCode.E))
        {
            Part_3.SetActive(true);
        }
        #endregion
        if(Part_1.activeSelf && Part_2.activeSelf && Part_3.activeSelf)
        {
            SceneManager.LoadScene("Outro");
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        #region meyve
        if (other.CompareTag("Meyve"))
        {
            M_Area = true;
        }
        else
        {
            M_Area = false;
        }
        #endregion
        #region Silah
        if (other.CompareTag("Silah"))
        {
            S_Area = true;
        }
        else
        {
            S_Area = false;
        }
        #endregion
        #region Part_1
        if (other.CompareTag("Part_1"))
        {
            Area_1 = true;
        }
        else
        {
            Area_1 = false;
        }
        #endregion
        #region Part_2
        if (other.CompareTag("Part_2"))
        {
            Area_2 = true;
        }
        else
        {
            Area_2 = false;
        }
        #endregion
        #region Part_3
        if (other.CompareTag("Part_3"))
        {
            Area_3 = true;
        }
        else
        {
            Area_3 = false;
        }
        #endregion
    }
}
