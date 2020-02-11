//Jonathan Ogilvie M00671608

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControl : MonoBehaviour
{
    public float speed = 10.0f;
    public float jumpForce = 5f;
    public Rigidbody player;
    private bool grounded;


    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        grounded = true;
    }

    // Update is called once per frame
    void Update()
    {
        float translation = Input.GetAxis("Vertical") * speed;
        float straffe = Input.GetAxis("Horizontal") * speed;
        translation *= Time.deltaTime;
        straffe *= Time.deltaTime;

        transform.Translate(straffe, 0, translation);

        if (Input.GetKeyDown("escape"))
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }

        if (Input.GetButton("Jump") && grounded == true)
        {
            player.velocity = new Vector3(0f, jumpForce, 0f);
        }

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            speed = speed * 2;
        }

        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            speed = speed / 2;
        }
    }
}//End of script
