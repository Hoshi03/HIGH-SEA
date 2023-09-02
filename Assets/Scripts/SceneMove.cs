using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMove : MonoBehaviour
{
    public GameObject t1;
    public GameObject t2;
    public GameObject t1Btn;
    public GameObject t2Btn;
    public void Start()
    {

    }
    public void MoveScene1()
    {
        SceneManager.LoadScene("Map");
    }
    public void MoveScene2()
    {
        SceneManager.LoadScene("Hint");
    }
    public void MoveScene3()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void MoveScene4()
    {
        SceneManager.LoadScene("Hint-Map");
    }
    public void MoveScene5()
    {
        SceneManager.LoadScene("Prologue");
    }

    public void store()
    {
        SceneManager.LoadScene("Store", LoadSceneMode.Additive);
    }

    public void pro1()
    {
        t1.SetActive(false);
        t1Btn.SetActive(false);
        t2.SetActive(true);
        t2Btn.SetActive(true);
    }

    public void Ending()
    {
        Application.Quit();
    }
}
