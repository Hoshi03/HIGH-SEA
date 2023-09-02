using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SubMarine : MonoBehaviour
{
    public void Start()
    {

    }
    public void Upgrade()
    {
        GameManager.instance.submarine += 1;
        GameManager.instance.Playerhp += 50;
        GameManager.instance.PlayerDmg += 10;
        GameManager.instance.ClearPoint += 1;
        SceneManager.LoadScene("Map");
    }


}
