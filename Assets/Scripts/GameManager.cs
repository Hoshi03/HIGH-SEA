using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public int Playerhp;//플레이어 hp
    public int Monsterhp;//몬스터 hp
    public int CannonPow;//캐논 파워 업!, 데미지 증가
    public int Cannons;//캐논 숫자!, 데미지 배수
    public int Stage;//현재 스테이지
    public int PlayerDmg;//플레이어 기본 데미지
    public int MonsterDmg;//몬스터 기본 데미지
    public int CurrentTurn;//현재 전투 턴
    public bool Turn;//플레이어 공격 턴
    public bool Guard;//플레이어 가드 선택
    public int Dice;
    public int Hunt;
    public int submarine;
    public int ClearPoint;//
    public int Gold;
    public int RandomBox;
    public bool randomBoxon;

    void Awake()
    {
        randomBoxon = true;
        Turn = true;
        Guard = false;
        if (instance != null)
        {
            Destroy(this.gameObject); // 해당 스크립트를 삭제
            return;
        }

        instance = this;
        DontDestroyOnLoad(this);
    }
}