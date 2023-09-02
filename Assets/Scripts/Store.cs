using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Store : MonoBehaviour
{
    public void hp()
    {
        if (GameManager.instance.Gold >= 1)
        {
            GameManager.instance.Gold += -1;
            GameManager.instance.Playerhp += 10;
        }
    }

    public void damage()
    {
        if (GameManager.instance.Gold >= 3)
        {
            GameManager.instance.Gold += -3;
            GameManager.instance.PlayerDmg += 10;
        }
    }
}
