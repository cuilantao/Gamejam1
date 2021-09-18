using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IslandScript : MonoBehaviour
{
    // Start is called before the first frame update

    void Start()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            Debug.Log("GAME OVER!!");
            Destroy(collision.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
