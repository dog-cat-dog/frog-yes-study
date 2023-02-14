using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    public static CheckPoint instance;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        Vector3 pos = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //GameObject.FindGameObjectsWithTag("CheckPoint").transform.position;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player") // pega layer a qual o objeto desse script esta colidindo
        {
            
            
        }
    }
}
