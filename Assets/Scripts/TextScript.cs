using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class TextScript : MonoBehaviour
{
    private TextMeshProUGUI text;
    // Use this for initialization
    void Start()
    {
        //Här så säger jag till att jag hämtar ut min TextMeshProUGUI
        text = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        // jag konverterar mitt text objekt till string och lägger till min score ¨{0:0000}"
    
        text.text = string.Format("score: {0:0000}", Coin.score);
    }
}
