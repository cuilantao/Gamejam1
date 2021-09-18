using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeCollider : MonoBehaviour
{
    // Start is called before the first frame update
    public PlayerInshadow plyer_shadow;
    void Start()
    {
        plyer_shadow = GameObject.FindObjectOfType<PlayerInshadow>();
    }

    private void OnTriggerEnter(Collider other)
    {
        plyer_shadow.set_shadow(true);
    }

    private void OnTriggerExit(Collider other)
    {
        plyer_shadow.set_shadow(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
