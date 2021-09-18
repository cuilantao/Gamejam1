using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HpPot : MonoBehaviour
{
    // Start is called before the first frame update
    public PlayerHPManager hp_man;
    void Start()
    {
        hp_man = GameObject.FindObjectOfType<PlayerHPManager>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            hp_man.incrementHp();
            Destroy(this.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
