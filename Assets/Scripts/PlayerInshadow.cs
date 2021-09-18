using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInshadow : MonoBehaviour
{
    // Start is called before the first frame update
    public Text shadow_controller;
    private bool in_shadow;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (in_shadow)
        {
            shadow_controller.text = "In Shadow!!";
        }
        else
        {
            shadow_controller.text = "Out of Shadow!!";
        }
    }

    public void set_shadow(bool s)
    {
        in_shadow = s;
    }

    public bool get_shadow()
    {
        return in_shadow;
    }
}
