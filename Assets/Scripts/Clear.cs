using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Clear : MonoBehaviour
{
    public void Start()
    {

    }
    public void Point()
    {
        GameManager.instance.Hunt += 1;
        GameManager.instance.ClearPoint += 1;
        GameManager.instance.Gold += 5;
        SceneManager.LoadScene("map");
        GameManager.instance.CurrentTurn = 0;
    }
}
