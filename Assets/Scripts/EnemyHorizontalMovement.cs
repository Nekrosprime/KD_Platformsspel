using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHorizontalMovement : MonoBehaviour

{
    // public float speed är när jag sätter själva farten till min enemy
    public float speed = 2f;
    // public bool left är att min enemy kollar åt vänster först. 
    public bool left = true;



    private Rigidbody2D rbody;
    // Use this for initialization
    void Start()
    {
        //Jag säger att jag vill ha just den här RigiBody eftersom att det finns flera olika och jag vill just ha den som finns i min component
        rbody = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        if (left == true)
        {
            // har säger jag till att min enemy går till vänster. När man skriver "-(vector2) transform.right * speed" så säger du att den ska 
            // gå till vänster instället för höger eftersom att du lägger till "-".
            rbody.velocity = -(Vector2)transform.right * speed;
            //Här så säger jag att min enemy har rätt scale på den 
            transform.localScale = new Vector3(1, 1, 1);
        }
        else
        {
            // har säger jag till att min enemy går till höger. När man skriver "(vector2) transform.right * speed" så säger du att den ska 
            // gå till höger instället för vänster eftersom att du tar bort "-" 
            rbody.velocity = (Vector2)transform.right * speed;
            // Här så säger jag att min enemy har rätt scale på den 
            transform.localScale = new Vector3(-1, 1, 1);
        }


    }
    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
        // när min enemy når InvisibleWall så ska den åka till höger istället vilket i kod man skriver som "!left" vilket betyder "inte left" 
        // motsatsen till vänster är höger
    {
        if (collision.tag == "InvisibleWall")
        {
            left = !left;
        }

    }

}
