using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetSpriteInvisible : MonoBehaviour
{

    // Use this for initialization
    void Start()
        //Jag hämtar  Componenten som är en spriteRenderer och säger år den att enabled == false vilket kommer att stänga av den 
        //när man startar spelet. 
    {
        GetComponent<SpriteRenderer>().enabled = false; 
    }
    
}
