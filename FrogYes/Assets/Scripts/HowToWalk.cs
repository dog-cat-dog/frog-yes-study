using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class HowToWalk : MonoBehaviour
{
    private Renderer sr;
    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<Renderer>();
        sr.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collider) // metodo dieferene para Trigger - quando colide com um trigger
    {
        if (collider.gameObject.tag == "Player")
        {
            Debug.Log("Entyrouu 1");
            sr.enabled = true;
        }
    }

    void OnTriggerExit2D(Collider2D collider) // metodo dieferene para Trigger - quando colide com um trigger
    {
        if (collider.gameObject.tag == "Player")
        {
            Debug.Log("Entyrouu 2");
            sr.enabled = false;
            //Destroy(gameObject);
        }
    }
}
