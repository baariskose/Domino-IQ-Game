using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    GecisReklam gecisReklam;
    
    List<GameObject> enemies;
    List<GameObject> stones;
    InternetConnection ýnternetConnection ;
    Ball ball;
    Scene scene;
    public GameObject nextLevelPanel,gameOverPanel;
    public bool isGameStart;
    public bool isGameRestart;
    public bool isGameOver;
    public float gameOverTime;
    public AudioClip winSound,gameOverSound;
    bool isSounPlayed;
    AudioSource audioSource;
    public Text ýnternetConnect;
    // Start is called before the first frame update
    void Start()
    {
        enemies = new List<GameObject>();
        stones = new List<GameObject>();
        ýnternetConnection = gameObject.GetComponent<InternetConnection>();
        gecisReklam = gameObject.GetComponent<GecisReklam>();
        ball = GameObject.FindGameObjectWithTag("Ball").GetComponent<Ball>();
        enemies.AddRange(GameObject.FindGameObjectsWithTag("Enemy"));
        stones.AddRange(GameObject.FindGameObjectsWithTag("Stone"));
       
        scene = SceneManager.GetActiveScene();
        isSounPlayed = false;
        audioSource = gameObject.GetComponent<AudioSource>();
        foreach (var stone in stones)
        {
            stone.gameObject.GetComponent<Rigidbody2D>().freezeRotation = true;
        }
        isGameStart = false;
        isGameOver = false;
       if(PlayerPrefs.GetInt("Mute")==1)
        {
            AudioListener.pause = true;
        }
        else
        {
            AudioListener.pause = false;
        }
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if(ball != null)
        {
            if (ball.currentTime <= 0)
            {
                gameOverTime -= Time.deltaTime;

                if (gameOverTime <= 0 && enemies.Count != 0)
                {
                    isGameOver = true;
                    gameOverPanel.SetActive(true);
                    if (isSounPlayed == false)
                    {
                        audioSource.PlayOneShot(gameOverSound);
                        isSounPlayed = true;
                    }
                }
            }
        }
        if(ball != null)
        {
            if (ball.currentTime <= 0 || scene.buildIndex == 18)
            {
                foreach (var stone in stones)
                {
                    stone.gameObject.GetComponent<Rigidbody2D>().freezeRotation = false;
                }
            }
            if (ball.currentTime > 0)
            {
                foreach (var stone in stones)
                {
                    stone.gameObject.GetComponent<Rigidbody2D>().freezeRotation = true;
                }
            }
        }
        
        

        if(enemies.Count >0 && isGameStart == true)
        {
            for (int i = 0; i < enemies.Count; i++)
            {
                if (enemies[i].GetComponent<Enemy>().stoneIsHit == true)
                {
                    enemies.Remove(enemies[i]);

                }
                if (enemies.Count == 0)
                {
                    
                    nextLevelPanel.SetActive(true);
                  PlayerPrefs.SetInt("bolum", int.Parse(SceneManager.GetActiveScene().name) );
                  //  PlayerPrefs.SetInt("bolum", 61);
                    if (isSounPlayed == false)
                    {
                        audioSource.PlayOneShot(winSound);
                        isSounPlayed = true;
                    }
                }
            }
        }

     
    }
   
    public void NextLevel()
    {
        if(scene.buildIndex < 61)
        {
            if(ýnternetConnection.isConnected)
            {
                SceneManager.LoadScene(scene.buildIndex + 1);

            }
            else
            {
                ýnternetConnect.text = "You don't have internet connection please check it";
            }
           

        }
        else
        {
            SceneManager.LoadScene(0);
        }
       
    }
    public void Replay()
    {
        SceneManager.LoadScene(scene.buildIndex);
        if (gecisReklam.interstitial.IsLoaded())
        {
            gecisReklam.interstitial.Show();
        }
        
    }
    public void startGame()
    {
        if (ýnternetConnection.isConnected)
        {
            SceneManager.LoadScene(1);
        }
        else
        {
            ýnternetConnect.text = "You don't have internet connection please check it";
        }
    }
    
    public void goLevelSelect()
    {
        SceneManager.LoadScene(1);
    }
    public void goMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void Exit()
    {
        Application.Quit();
    }
  

}
