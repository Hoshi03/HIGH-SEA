using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Rest : MonoBehaviour
{
    // Start is called before the first frame update
    public void Start()
    {
    
    }
    public void JustRest()// 그냥 편안한 휴식
    {
        GameManager.instance.Playerhp += 10;
        GameManager.instance.ClearPoint += 1;
        SceneManager.LoadScene("map");
    }

    public void TheChoice()// 과감한 선택
    {
        int rand = Random.Range(-10, 30);
        GameManager.instance.Playerhp += rand;
        GameManager.instance.ClearPoint += 1;
        SceneManager.LoadScene("map");
    }
}
