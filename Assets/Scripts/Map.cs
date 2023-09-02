using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Map : MonoBehaviour
{
    public GameObject Stage1;
    public GameObject Stage2;
    public GameObject Stage3;
    public GameObject Stage4;
    public GameObject Stage5;
    public GameObject Stage6;
    public GameObject Stage7;
    public GameObject Stage8;
    public GameObject Stage9;
    public GameObject Stage10;
    public GameObject Stage11;
    public GameObject Stage12;
    public GameObject Stage13;


    void Start()
    {
        if (GameManager.instance.Stage >= 13)
        {
            SceneManager.LoadScene("Ending");
        }
        if (GameManager.instance.ClearPoint == 0)
        {
            Stage1.SetActive(true);
        }
        if (GameManager.instance.ClearPoint == 1)
        {
            Stage2.SetActive(true);
        }
        if (GameManager.instance.ClearPoint == 2)
        {
            Stage3.SetActive(true);
        }
        if (GameManager.instance.ClearPoint == 3)
        {
            Stage4.SetActive(true);
        }
        if (GameManager.instance.ClearPoint == 4)
        {
            Stage5.SetActive(true);
        }
        if (GameManager.instance.ClearPoint == 5)
        {
            Stage6.SetActive(true);
        }
        if (GameManager.instance.ClearPoint == 6)
        {
            Stage7.SetActive(true);
        }
        if (GameManager.instance.ClearPoint == 7)
        {
            Stage8.SetActive(true);
        }
        if (GameManager.instance.ClearPoint == 8)
        {
            Stage9.SetActive(true);
        }
        if (GameManager.instance.ClearPoint == 9)
        {
            Stage10.SetActive(true);
        }
        if (GameManager.instance.ClearPoint == 10)
        {
            Stage11.SetActive(true);
        }
        if (GameManager.instance.ClearPoint == 11)
        {
            Stage12.SetActive(true);
        }
        if (GameManager.instance.ClearPoint == 12)
        {
            Stage13.SetActive(true);
        }
    }
}
