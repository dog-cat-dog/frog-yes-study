using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Big_Kiwi : MonoBehaviour
{
    public Player player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collider) // metodo dieferene para Trigger - quando colide com um trigger
    {
        if (collider.gameObject.tag == "Player")
        {
            
            //player.numberDeaths = player.numberDeaths - 4;
            GameController.instance.Score += 4;
            //GameController.instance.Score = ;
            Destroy(gameObject);
        }
    }
}
