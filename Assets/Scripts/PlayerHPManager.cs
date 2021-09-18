using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerHPManager : MonoBehaviour
{
    // Start is called before the first frame update
    public Text playerHPManager;
    private double hp_remain = 30;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        playerHPManager.text = "HP: " + hp_remain;
    }

    public void incrementHp()
    {
        if (hp_remain < 100)
        {
            hp_remain += 10;
        }
    }

    public void decreaseHp()
    {
        hp_remain += -10;
    }

    public double get_hp()
    {
        return hp_remain;
    }
}
