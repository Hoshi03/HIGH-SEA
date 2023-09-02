using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BG : MonoBehaviour
{
    public Image BaseBG; 
    public Sprite num1;
    public Sprite num2;
    public Sprite num3;
    public Sprite num4;

    public void Start()
    {
        if (GameManager.instance.Stage >= 13)
        {
            SceneManager.LoadScene("Ending");
        }
        if (0 <= GameManager.instance.ClearPoint && GameManager.instance.ClearPoint <= 2)
        {
            BaseBG.sprite = num1;
        }
        if (3 <= GameManager.instance.ClearPoint && GameManager.instance.ClearPoint <= 5)
        {
            BaseBG.sprite = num2;
        }
        if (6 <= GameManager.instance.ClearPoint && GameManager.instance.ClearPoint <= 8)
        {
            BaseBG.sprite = num3;
        }
        if (9 <= GameManager.instance.ClearPoint && GameManager.instance.ClearPoint <= 12)
        {
            BaseBG.sprite = num4;
        }
    }
}
