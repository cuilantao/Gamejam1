using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInfoControl : MonoBehaviour
{
    public Text player_info;
    public float speed_boost_remaining = 0;
    float nextTime = 0;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        player_info.text = "Speed: " + speed_boost_remaining;
        if (Time.time >= nextTime)
        {
            nextTime += 1;
            if (speed_boost_remaining > 0)
            {
                speed_boost_remaining += -1;
            }
        }
    }

    public void GetSpeedBoost()
    {
        speed_boost_remaining += 5;
    }

    public double speed_remaining()
    {
        return speed_boost_remaining;
    }
}
