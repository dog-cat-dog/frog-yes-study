using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI; // adicionar para usar coisas de UI

public class Menu : MonoBehaviour
{


    
    public Button restartButton, leaveButton;
   // public GameController gc;

    

    public static Menu instance;
    // Start is called before the first frame update
    void Start()
    {
        //gc = GetComponent<GameController>();
        //GameController.instance.Score = 5;

    }

    // Update is called once per frame
    void Update()
    {

       
    }

    public void RestartGame(string lvlName) // metodo criado para quando clicar no botao de restart. É meio que OBRIGATORIO criar um método por causa da coisa la no unity mesmo
    {                                       // pq la no unity indicamos o nome do lvl em que estamos, sem precisar criar esse metodo para todos os lvls

        if (!Music.instance.music.isPlaying)
        {

            
            
               
            
            // é possível usar Music.isntance.music.... porque ela eh uma public static e eu usei la instance = this
            // não se usa sempre, pois é perigoso. Todas as classes pdoem acidentalmente mudar coisas dela..
            Music.instance.music.time = 2.4f; // adiantando um pouco a musica
            Music.instance.music.Play(); // mandando a musica começar a tocar
            
        }
        SceneManager.LoadScene(lvlName);

        // poderia ser scenemanager.LoadScene("Nome da cena");
    }

    public void NextScene(string lvlName) // 
    {
        SceneManager.LoadScene(lvlName);

    }
}