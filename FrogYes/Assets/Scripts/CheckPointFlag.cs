using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPointFlag : MonoBehaviour
{
    public static Animator animCheckPoint;
    // Start is called before the first frame update
    void Start()
    {
        animCheckPoint = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
