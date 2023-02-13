using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // adicionar para usar coisas de UI
using UnityEngine.SceneManagement; // para restartar uma cena precisa disso, para usar as coisas de cena
using Unity.VisualScripting;
using UnityEditor.PackageManager.UI;
using UnityEditor.SearchService;
using UnityEngine.SocialPlatforms.Impl;

public class GameController : MonoBehaviour
{

    public int Score; // será as vidas
    public Text scoreText;
    public Player player;
    public Button restartButton, leaveButton;
 

   

    public GameObject gameOver;

    public static GameController instance;
    // Start is called before the first frame update
    void Start()
    {
        Score = ScoreTotal.totalScore;
           
        instance = this;
        //DontDestroyOnLoad(this);

        

        /*if (PlayerPrefs.HasKey("Score"))
        {
            Score = PlayerPrefs.GetInt("Score");
        }
        else
        {
            Score = 5;
        }
         */   
    }

    // Update is called once per frame
    void Update()
    {
        if (Score != 5 && Score > 0)
        {
            ScoreTotal.totalScore = Score;
           // Debug.Log("O MAR ESTA NO LESTE");
            //Score = GameController.instance.Score;
        }

        Deaths();


        if (Score >= 5) {  // quando botei isso o restart ficou vermelho
            scoreText.material.color = Color.green;
        } else
            if (Score < 5)
        {
            scoreText.material.color = Color.red;
        }
            scoreText.text = Score.ToString();
        //player.Lifes = Score;
        //}
    }

    public void ShowGameOver()
    {
        gameOver.SetActive(true);
    }

    public void RestartGame(string lvlName) // metodo criado para quando clicar no botao de restart. É meio que OBRIGATORIO criar um método por causa da coisa la no unity mesmo
    {                                       // pq la no unity indicamos o nome do lvl em que estamos, sem precisar criar esse metodo para todos os lvls

        Debug.Log(lvlName + "AFJSAKFGJNA");
        ScoreTotal.totalScore = 5;
        SceneManager.LoadScene(lvlName);
        
        // poderia ser scenemanager.LoadScene("Nome da cena");
    }

    public void NextScene(string lvlName) // 
    {                                       
        SceneManager.LoadScene(lvlName);
        
    }
    void Deaths()
    {
        if (Score == 0)
        {
           // Destroy(gameObject);
            ShowGameOver();
        }
    }
    


}
