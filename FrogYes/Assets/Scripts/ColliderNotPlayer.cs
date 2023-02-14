using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderNotPlayer : MonoBehaviour
{
    private BoxCollider2D bc;
    // Start is called before the first frame update
    void Start()
    {
        bc = GetComponent<BoxCollider2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player") // pega layer a qual o objeto desse script esta colidindo
        {
            //Debug.Log("PAÇOCA");
            //Physics2D.IgnoreCollision(collision.gameObject.GetComponent<BoxCollider2D>(), gameObject.GetComponent<BoxCollider2D>()) ; 
            bc.isTrigger = true;
        }
        
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player") // pega layer a qual o objeto desse script esta colidindo
        {
            //bc.enabled = true;
            Debug.Log("PAÇOCA");
            bc.isTrigger = false;
        }
    }
    void OnTriggerExit2D(Collider2D collider) // metodo dieferene para Trigger - quando colide com um trigger
    {
        if (collider.gameObject.tag == "Player") // pega layer a qual o objeto desse script esta colidindo
        {
            //bc.enabled = true;
            
            bc.isTrigger = false;
        }
    }
}
