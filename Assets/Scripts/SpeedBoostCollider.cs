using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBoostCollider : MonoBehaviour
{
    // Start is called before the first frame update
    public PlayerInfoControl info_controller;
    void Start()
    {
        info_controller = GameObject.FindObjectOfType<PlayerInfoControl>();
    }

    // Update is called once per frame

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            // give movement speed bonus
            info_controller.GetSpeedBoost();
            Destroy(this.gameObject);
        }
    }
    void Update()
    {
        
    }
}
