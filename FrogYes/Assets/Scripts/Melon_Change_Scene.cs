using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Melon_Change_Scene : MonoBehaviour
{
    public GameController gameController;
    public string scene;
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

            // SceneManager.LoadScene("Game Over");
            
            gameController.NextScene(scene);
            Destroy(gameObject);
            ScoreTotal.levelMelonScore += 1;

            Debug.Log("level melon score " + ScoreTotal.levelMelonScore);
            
        }
    }
}
