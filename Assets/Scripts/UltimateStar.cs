using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UltimateStar : MonoBehaviour
{
    public float Spinspeedstar = 180;
    // Update is called once per frame
    private void Update()
    {
        // så att den roterar runt sin y Axel 
        transform.Rotate(0, Spinspeedstar * Time.deltaTime, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}




