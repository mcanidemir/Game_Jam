using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public GameObject verypast;
    public GameObject past;
    public GameObject future;
    public GameObject Menu;
    public GameObject Sound_Menu;
    public GameObject _player;
    public GameObject Dead;
    public GameObject Tree;
    public GameObject TreeWay;
    public GameObject TreeWay2;
    public int MenuVisible = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        #region world1
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            verypast.SetActive(true);
            past.SetActive(false);
            future.SetActive(false);
        }
        #endregion
        #region world2
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            past.SetActive(true);
            verypast.SetActive(false);
            future.SetActive(false);
        }
        #endregion
        #region world3
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            past.SetActive(false);
            verypast.SetActive(false);
            future.SetActive(true);
        }
        #endregion
        ESCcount();

        if (MenuVisible % 2 == 0)
        {
            Menu.SetActive(false);
            _player.SetActive(true);
        }
        else
        {
            Menu.SetActive(true);
            _player.SetActive(false);
        }
        Died();

        if (Tree.activeSelf)
        {
            TreeWay.SetActive(true);
            TreeWay2.SetActive(true);
        }
        else if (!Tree.activeSelf)
        {
            TreeWay.SetActive(false);
            TreeWay2.SetActive(false);
        }
    }
    public void ESCcount()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            MenuVisible += 1;
        }
    }
    public void Resume()
    {
        Menu.SetActive(false);
        MenuVisible += 1;
    }
    public void Restart()
    {
        SceneManager.LoadScene("CurrentTime");
    }
    public void SoundMenu()
    {
        Sound_Menu.SetActive(true);
        MenuVisible += 1;
    }
    public void SoundMenuClose()
    {
        Sound_Menu.SetActive(false);
        MenuVisible++;
    }
    public void Died()
    {
        if (_player.transform.position.y < -350)
        {
            _player.SetActive(false);
            Dead.SetActive(true);
        }
    }

}
