using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MapText : MonoBehaviour
{
    public Text hpText;
    public Text goldText;
    public int StageNum;
    public Text StageText;
    // Update is called once per frame
    public void Update()
    {
        StageNum = GameManager.instance.ClearPoint + 1;
        StageText.text = StageNum.ToString();
        hpText.text = GameManager.instance.Playerhp.ToString();
        goldText.text = GameManager.instance.Gold.ToString();
    }
}
