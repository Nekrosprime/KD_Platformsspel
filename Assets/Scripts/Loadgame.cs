using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class Loadgame : MonoBehaviour
{
    // Här så säger jag att det lägsta poängen för att klara banan är 0
    public int minimumScoreNeeded = 0; 
    // När spelaren plockar upp ett poäng så laddas det i banan och vissar att du har 1 poäng 
    public string SceneToLoad = "SampleScene"; 

    private void OnTriggerEnter2D(Collider2D collision)
    {
     if(collision.tag == "Player")
        {
            // när du laddar in banan så har du 0 poäng 
            Coin.score = 0; 
            SceneManager.LoadScene(SceneToLoad);
        }
    }


}
