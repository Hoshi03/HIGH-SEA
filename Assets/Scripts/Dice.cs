using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Dice : MonoBehaviour
{
    public Image BaseImage; //canvas-image
    public Sprite num1;
    public Sprite num2;
    public Sprite num3;
    public Sprite num4;
    public Sprite num5;
    public Sprite num6;

    public void Start()
    {
        if (GameManager.instance.ClearPoint >= 12)
        {
            SceneManager.LoadScene("Ending");
        }
    }

    public void ChangeImage1()//주사위
    {
        GameManager.instance.Dice = Random.Range(1,7);
        Debug.Log(GameManager.instance.Dice);
        if (GameManager.instance.Dice == 1)
        {
            BaseImage.sprite = num1;
        }
        if (GameManager.instance.Dice == 2)
        {
            BaseImage.sprite = num2;
        }
        if (GameManager.instance.Dice == 3)
        {
            BaseImage.sprite = num3;
        }
        if (GameManager.instance.Dice == 4)
        {
            BaseImage.sprite = num4;
        }
        if (GameManager.instance.Dice == 5)
        {
            BaseImage.sprite = num5;
        }
        if (GameManager.instance.Dice == 6)
        {
            BaseImage.sprite = num6;
        }
    }

    public void selcetStage()
    {
        
        GameManager.instance.Dice = Random.Range(1, 7);
        Debug.Log(GameManager.instance.Dice);
        if (GameManager.instance.Dice == 1)
        {
            BaseImage.sprite = num1;
            SceneManager.LoadScene("Battle");
        }
        if (GameManager.instance.Dice == 2)
        {
            BaseImage.sprite = num2;
            GameManager.instance.Playerhp += 20;
            SceneManager.LoadScene("Battle");
        }
        if (GameManager.instance.Dice == 3)
        {
            BaseImage.sprite = num3;
            GameManager.instance.Playerhp += 40;
            SceneManager.LoadScene("Battle");
        }
        if (GameManager.instance.Dice == 4)
        {
            BaseImage.sprite = num4;
            SceneManager.LoadScene("Rest");
        }
        if (GameManager.instance.Dice == 5)
        {
            BaseImage.sprite = num5;
            SceneManager.LoadScene("RandomBox");
        }
        if (GameManager.instance.Dice == 6)
        {
            BaseImage.sprite = num6;
            SceneManager.LoadScene("Upgrade");
        }

    }
}
