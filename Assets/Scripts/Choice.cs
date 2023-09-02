using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Choice : MonoBehaviour
{
    public void One1()
    {
        GameManager.instance.Playerhp -= 20;
        GameManager.instance.ClearPoint += 1;
        SceneManager.LoadScene("map");
    }
    public void One2()
    {
        GameManager.instance.Gold += 3;
        GameManager.instance.ClearPoint += 1;
        SceneManager.LoadScene("map");
    }
    public void Two1()
    {
        GameManager.instance.Playerhp += 10;
        GameManager.instance.PlayerDmg += 5;
        GameManager.instance.ClearPoint += 1;
        SceneManager.LoadScene("map");
    }
    public void Two2()
    {
        GameManager.instance.Playerhp -= 20;
        GameManager.instance.ClearPoint += 1;
        SceneManager.LoadScene("map");
    }
}
