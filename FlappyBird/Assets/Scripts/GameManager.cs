using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private int score;
    public GameObject playButton;
    public GameObject quitButton;

    public GameObject gameOver;
    public Text scoreText;
    public Player player;
    public GameObject flappyBird;
    // Start is called before the first frame update

    /// Awake is called when the script instance is being loaded.
  
    private void Awake()
    {
        Pause();
        gameOver.SetActive(false);
    }
    public void Play()
    {
       score = 0;
       scoreText.text = score.ToString();
       gameOver.SetActive(false);
       quitButton.SetActive(false);
       playButton.SetActive(false);
       Cursor.visible=false;
       
       //flappyBird.gameObject.transform.position =  new Vector3(0,0,-1);

       Time.timeScale=1f;
       player.enabled= true;
       
       Pipes[] pipes= FindObjectsOfType<Pipes>();
       for ( int i= 0; i < pipes.Length; i++)
       {
         Destroy(pipes[i].gameObject);
       }
    }

    public void Pause()
    {
        Time.timeScale = 0f ;
        player.enabled = false;
        Cursor.visible= true;
    }
    public void IncreaseScore()
    {
     score++;
     scoreText.text = score.ToString();
    }

    public void Quit()
    {
      Application.Quit();
     
    }
    public void GameOver()
    {
      gameOver.SetActive(true);
      playButton.SetActive(true);
      quitButton.SetActive(true);

      Pause();
    }
}
