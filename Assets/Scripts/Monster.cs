using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Monster : MonoBehaviour
{
    public Image Basemonster;
    public Sprite m1;
    public Sprite m2;
    public Sprite m3;
    public Sprite m4;
    public Sprite m5;
    public Sprite m6;
    public Sprite m7;
    public Sprite m8;
    public Sprite m9;
    public void Start()
    {
     
        int rand = Random.Range(1, 9);
        if(rand == 1)
        {
            Basemonster.sprite = m1;
        }
        if (rand == 2)
        {
            Basemonster.sprite = m3;
        }
        if (rand == 3)
        {
            Basemonster.sprite = m3;
        }
        if (rand == 4)
        {
            Basemonster.sprite = m4;
        }
        if (rand == 5)
        {
            Basemonster.sprite = m5;
        }
        if (rand == 6)
        {
            Basemonster.sprite = m6;
        }
        if (rand == 7)
        {
            Basemonster.sprite = m7;
        }
        if (rand == 8)
        {
            Basemonster.sprite = m8;
        }
        if (rand == 9)
        {
            Basemonster.sprite = m9;
        }
    }

    public void Update()
    {
        MonsterAttack();
    }

    public void MonsterAttack()
    {
        if (GameManager.instance.Turn == false && GameManager.instance.Guard == false)
        {
            GameManager.instance.Playerhp -= GameManager.instance.MonsterDmg;
            Debug.Log("남은 플레이어 hp: " + GameManager.instance.Playerhp);
            GameManager.instance.Turn = true;
        }
        
        if (GameManager.instance.Turn == false && GameManager.instance.Guard == true)
        {
            GameManager.instance.Playerhp -= GameManager.instance.MonsterDmg / 2;
            Debug.Log("남은 플레이어 hp: " + GameManager.instance.Playerhp);
            GameManager.instance.Turn = true;
        }
        

        if (GameManager.instance.Monsterhp <= 0 && GameManager.instance.Turn == true)
        {
            Destroy(gameObject);
            SceneManager.LoadScene("Clear", LoadSceneMode.Additive);
            GameManager.instance.Monsterhp = 100;
            if (GameManager.instance.Hunt == 0)
            {
                GameManager.instance.Monsterhp += 50;
                GameManager.instance.MonsterDmg += 5;
            }

            if (GameManager.instance.Hunt == 1)
            {
                GameManager.instance.Monsterhp += 100;
                GameManager.instance.MonsterDmg += 10;
            }

            if (GameManager.instance.Hunt == 2)
            {
                GameManager.instance.Monsterhp += 150;
                GameManager.instance.MonsterDmg += 15;
            }

            if (GameManager.instance.Hunt == 3)
            {
                GameManager.instance.Monsterhp += 200;
                GameManager.instance.MonsterDmg += 20;
            }

            if (GameManager.instance.Hunt == 4)
            {
                GameManager.instance.Monsterhp += 250;
                GameManager.instance.MonsterDmg += 25;
            }

            if (GameManager.instance.Hunt == 5)
            {
                GameManager.instance.Monsterhp += 300;
                GameManager.instance.MonsterDmg += 30;
            }

            if (GameManager.instance.Hunt == 6)
            {
                GameManager.instance.Monsterhp += 350;
                GameManager.instance.MonsterDmg += 35;
            }

            if (GameManager.instance.Hunt == 7)
            {
                GameManager.instance.Monsterhp += 400;
                GameManager.instance.MonsterDmg += 40;
            }

            if (GameManager.instance.Hunt == 8)
            {
                GameManager.instance.Monsterhp += 450;
                GameManager.instance.MonsterDmg += 45;
            }

            if (GameManager.instance.Hunt == 9)
            {
                GameManager.instance.Monsterhp += 500;
                GameManager.instance.MonsterDmg += 50;
            }

            if (GameManager.instance.Hunt == 10)
            {
                GameManager.instance.Monsterhp += 550;
                GameManager.instance.MonsterDmg += 55;
            }

            if (GameManager.instance.Hunt == 11)
            {
                GameManager.instance.Monsterhp += 600;
                GameManager.instance.MonsterDmg += 60;
            }

            GameManager.instance.Turn = false;
            GameManager.instance.CurrentTurn = 0;
        }
    }
}
