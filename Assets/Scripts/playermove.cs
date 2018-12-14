using System.Collections.Generic;
using UnityEngine;

public class playermove : MonoBehaviour
{
    public float movespeed = 6f;
    public float jumpspeed = 12f;

    public GroundChecker groundcheck;

    private Rigidbody2D rbody;

    // Use this for initialization
    void Start()
    {
        // hämtar ut min RigiBody som jag vill använda eftersom att det finns flera olika och jag vill ha den jag använder
        rbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //Min spelare rör sig till vänster eller höger om man trycker på A,D 
        rbody.velocity = new Vector2(
            Input.GetAxis("Horizontal") * movespeed,
            rbody.velocity.y);
        // OM jag trycker på min jump knapp vilket är "Space" så hoppar jag 
        if (Input.GetButtonDown("Jump"))
        {
          
            if (groundcheck.isGround == true)
            {
                // Denna kod gör så att min spelare hoppar när man trycker på hopp knappen 
                rbody.velocity = new Vector2(
                    rbody.velocity.x,
                    jumpspeed);
            }

        }

    }
}
