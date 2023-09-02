using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public Image BaseImage;
    public GameObject life;
    public Sprite num1;
    public Sprite num2;
    public Sprite num3;
    public Sprite num4;
    public Sprite num5;
    public Sprite num6;
    public Sprite s1;
    public Sprite s2;
    public Sprite s3;
    public Sprite s4;
    // Start is called before the first frame update
    public void Start()
    {
        GameManager.instance.Turn = true;
        GameManager.instance.CurrentTurn = 0;
        if (GameManager.instance.submarine == 1)
        {
            BaseImage.sprite = s2;
        }
        if (GameManager.instance.submarine == 2)
        {
            BaseImage.sprite = s3;
        }
        if (GameManager.instance.submarine >= 3)
        {
            BaseImage.sprite = s4;
        }
    }

    public void Update()
    {
        PlayerDie();
    }

    // Update is called once per frame
    public void PlayerAttack()
    {
        if (GameManager.instance.Turn == true)
        {
            GameManager.instance.Dice = Random.Range(1, 6);
            Debug.Log(GameManager.instance.Dice);
            
            GameManager.instance.Monsterhp -= (GameManager.instance.PlayerDmg * GameManager.instance.Cannons + GameManager.instance.CannonPow + GameManager.instance.Dice);//플레이어 데미지 계산식
            Debug.Log("남은 몬스터 hp: " + GameManager.instance.Monsterhp);
            GameManager.instance.Turn = false;
            GameManager.instance.CurrentTurn += 1;
        }
    }
    public void PlayerGuard()
    {
        if (GameManager.instance.Turn == true)
        {
            GameManager.instance.Guard = true;
            GameManager.instance.Turn = false;
            GameManager.instance.CurrentTurn += 1;
        }
    }
    public void PlayerRun()
    {
        if(GameManager.instance.Turn == true && GameManager.instance.CurrentTurn >= 2){
            GameManager.instance.ClearPoint += 1;
            SceneManager.LoadScene("map");
        }
    }
    public void PlayerDie()
    {
        if(GameManager.instance.Playerhp <= 0)
        {
            GameManager.instance.Playerhp = 100;
            GameManager.instance.Monsterhp = 100;
            GameManager.instance.CannonPow = 0;
            GameManager.instance.Cannons = 1;
            GameManager.instance.Stage = 1;
            GameManager.instance.PlayerDmg = 10;
            GameManager.instance.MonsterDmg = 5;
            GameManager.instance.CurrentTurn = 0;
            GameManager.instance.Turn = true;
            GameManager.instance.Guard = false;
            GameManager.instance.Dice = 0;
            GameManager.instance.ClearPoint = 0;
            GameManager.instance.Gold = 0;
            GameManager.instance.Hunt = 0;
            GameManager.instance.submarine = 0;
            SceneManager.LoadScene("MainMenu");
        }
    }
}
