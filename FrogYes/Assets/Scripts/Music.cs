using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    public AudioSource music;
    public static Music instance;
    

    // Start is called before the first frame update
    void Start()
    {

        instance = this;
        
        //instance.music = GetComponent<AudioSource>();
        
        

        
    }

    // Update is called once per frame
    void Update()
    {
       // DontDestroyOnLoad(gameObject);
        
        //music = GetComponent<AudioSource>();
    }

    public void DestroyMusic()
    {
       // Destroy(gameObject);
    }

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
}
