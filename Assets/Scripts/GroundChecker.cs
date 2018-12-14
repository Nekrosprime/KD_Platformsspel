using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundChecker : MonoBehaviour
{
    // håller koll på om jag är vid marken eller inte 
    public bool isGround;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // här så säger jag att när min spelare är vid marken så står han  där. 
        isGround = true; 
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        // här så säger jag att när min spelare hoppar t.ex så är han inte vid marken. 
        isGround = false;
    }
}

