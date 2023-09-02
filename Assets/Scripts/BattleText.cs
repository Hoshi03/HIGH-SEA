using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleText : MonoBehaviour
{
    public int dmg;
    public Text playetHp;
    public Text monsterHp;
    public Text CurrentTurn;
    public Text PlayerDmg;
    public Text MonsterDmg;
    public void Start()
    {
        dmg = GameManager.instance.PlayerDmg * GameManager.instance.Cannons + GameManager.instance.CannonPow;
    }

    public void Update()
    {
        playetHp.text = GameManager.instance.Playerhp.ToString();
        monsterHp.text = GameManager.instance.Monsterhp.ToString();
        CurrentTurn.text = GameManager.instance.CurrentTurn.ToString();
        PlayerDmg.text = dmg.ToString();
        MonsterDmg.text = GameManager.instance.MonsterDmg.ToString();
    }
}
