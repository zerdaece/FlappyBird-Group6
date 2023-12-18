
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using JetBrains.Annotations;

public class GameManager : MonoBehaviour
{
    public int score;
    public GameObject playButton;
    public GameObject quitButton;
    public GameObject shopping;
    private float startTime;

    public GameObject gameOver;
    public Text scoreText;
    public Player player;
    public GameObject flappyBird;
    public GameObject playbuttonImage;
    public GameObject tryagainButton;
    public ShopManager shopManager;
    // Start is called before the first frame update

    /// Awake is called when the script instance is being loaded.
  
    private void Awake()
    {
        Pause();
        gameOver.SetActive(false);
        tryagainButton.SetActive(false);

    }
    void Start()
    {
        // Eğer daha önce kaydedilmiş bir başlangıç zamanı varsa, onu al.
        if (PlayerPrefs.HasKey("BaslamaZamani"))
        {
            startTime = PlayerPrefs.GetFloat("BaslamaZamani");
        }
        else
        {
            // İlk defa başlatılıyorsa, şu anki zamanı kaydet.
            startTime = Time.time;
            PlayerPrefs.SetFloat("BaslamaZamani", startTime);
            PlayerPrefs.Save();
        }
    }
    public void Play()
    {
       score = 0;
       scoreText.text = score.ToString();
       gameOver.SetActive(false);
       quitButton.SetActive(false);
       playButton.SetActive(false);
       Cursor.visible=false;
       shopping.SetActive(false);
       playbuttonImage.SetActive(false);
       tryagainButton.SetActive(false);
       
       
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
    /*public void MultipleScore()
    {
      score += 2 ;
      scoreText.text=score.ToString();
    }*/

    public void Quit()
    {
      Application.Quit();
     
    }
    public void GameOver()
    {
      gameOver.SetActive(true);
      playButton.SetActive(false);
      tryagainButton.SetActive(true);
      quitButton.SetActive(true);
      playbuttonImage.SetActive(false);
      shopping.SetActive(true);
      PlayerPrefs.SetFloat("SonOyunZamani", Time.time);
      PlayerPrefs.Save();

      Pause();
    }
}
