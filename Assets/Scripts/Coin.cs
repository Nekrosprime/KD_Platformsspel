using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    //min variabel för Score
    public static int score; 
    // Hur mcyket jag får när jag plockar up en coin (jag får 1 poäng)
    public int amount = 1;
    // Så att coin snurar med speed 180 
    public float spinSpeed = 180;

    private void Update()
    {
        // så att den roterar runt sin y Axel 
        transform.Rotate(0, spinSpeed * Time.deltaTime, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // om min spelare nudar coin så plockar han upp den
        if (collision.tag == "Player")
        {
            //När spelaren plockar upp en Coin så får han 1 poäng 
            Coin.score += amount; 
            Destroy(gameObject); 
        }
    }
}
