using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RandomBox : MonoBehaviour
{
    public GameObject event1;
    public GameObject n1;
    public GameObject n2;
    public GameObject n3;
    public GameObject n4;
    public GameObject n5;
    public GameObject n6;
    // Start is called before the first frame update

    public void Event()
    {
        event1.SetActive(false);
        GameManager.instance.randomBoxon = true;
        GameManager.instance.RandomBox = Random.Range(1, 3);
        Debug.Log(GameManager.instance.RandomBox);
        if (GameManager.instance.RandomBox == 1 && GameManager.instance.randomBoxon == true)
        {
            n1.SetActive(true);
            n2.SetActive(true);
            n3.SetActive(true);
        }
        if (GameManager.instance.RandomBox == 2 && GameManager.instance.randomBoxon == true)
        {
            n4.SetActive(true);
            n5.SetActive(true);
            n6.SetActive(true);
        }
        GameManager.instance.randomBoxon = false;

    }
    public void One1() 
    {
        SceneManager.LoadScene("1-1", LoadSceneMode.Additive);
    }
    public void One2()
    {
        SceneManager.LoadScene("1-2", LoadSceneMode.Additive);
    }

    public void Two1()
    {
        SceneManager.LoadScene("2-1", LoadSceneMode.Additive);
    }
    public void Two2()
    {
        SceneManager.LoadScene("2-2", LoadSceneMode.Additive);
    }
}
