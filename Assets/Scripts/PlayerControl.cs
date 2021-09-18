using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private float forward;
    private float left;
    private float movement_speed = 5;
    private Vector3 jump;
    private float jumpForce = 2.5f;
    public bool is_grounded;
    Rigidbody rb;
    public PlayerInfoControl info_controller;
    public PlayerHPManager pl_hp;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        jump = new Vector3(0, 2, 0);
        info_controller = GameObject.FindObjectOfType<PlayerInfoControl>();
        pl_hp = GameObject.FindObjectOfType<PlayerHPManager>();
    }

    void OnCollisionStay(Collision coll)
    {
        if (coll.gameObject.name == "Terrain")
        {
            is_grounded = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (pl_hp.get_hp() <= 0)
        {
            Destroy(this.gameObject);
        }
        if (info_controller.speed_remaining() > 0)
        {
            movement_speed = 7;
        }
        else
        {
            movement_speed = 5;
        }


        if (Input.GetKeyDown(KeyCode.Space) && is_grounded)
        {
            is_grounded = false;
            rb.AddForce(jump * jumpForce, ForceMode.Impulse);
        }


        forward = Input.GetAxis("Vertical");
        left = Input.GetAxis("Horizontal");
        transform.position += Vector3.forward * forward * Time.deltaTime * movement_speed;
        transform.position += Vector3.right * left * Time.deltaTime * movement_speed;
    }
}
