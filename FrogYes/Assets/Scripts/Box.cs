using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    private FixedJoint2D fx;
    private bool mc, a;
    // Start is called before the first frame update
    void Start()
    {
        fx = GetComponent<FixedJoint2D>();
        // GameController gc = new GameController();
        
        
    }

    // Update is called once per frame
    void Update()
    {
        mc = GameController.instance.mouseClick;
        if (Input.GetKey("e")) // permite ler se o bota continua pressionado
        {
           
            //Debug.Log("deu mouse click igual a true");
        }
       /* if (mc == true) // pega layer a qual o objeto desse script esta colidindo
        {
            Debug.Log("FIREWORK");
            
        }
       */
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player" && mc == false) // pega layer a qual o objeto desse script esta colidindo
        {
            Debug.Log("ILARI LARI LARIE");
            fx.enabled = false;
        } 
            
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player" && Input.GetKey("e") == true)
        {
            fx.enabled = true;
            fx.connectedBody = Player.instance.GetComponent<Rigidbody2D>();
            Debug.Log("DONA DE MIMMMMM");

            
        }
        if (Input.GetKey("e") == false)
        {
            Debug.Log("DONA DE MIMMMMM 22222");
            fx.enabled = false;
        }
    }
}

