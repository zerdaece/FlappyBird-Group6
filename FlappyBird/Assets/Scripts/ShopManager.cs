using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class ShopManager : MonoBehaviour
{
  public GameObject shoppingCanvas;
  public GameManager GM;
  public int newScoreforResurgence;
  public GameObject forScore;
  public GameObject forresurgence;



  public void ShoppingMenu()
  {
    //SceneManager.LoadScene("Shopping");

    //Ortaya shopping canvas gelecek//
    shoppingCanvas.gameObject.SetActive(true);
    forScore.SetActive(false);
    forresurgence.SetActive(false);

  }
  public void CloseShopMenu()
  {
    shoppingCanvas.gameObject.SetActive(false);

  }
  public void Resurgence()
  {
        Time.timeScale = 1f ;
        GM.player.enabled = true;
        Cursor.visible = false;
        
        GM.gameOver.SetActive(false);
        GM.tryagainButton.SetActive(false);
        if (GM.score>10)
        {
          shoppingCanvas.gameObject.SetActive(false);
          GM.score -= 10;
        }
        else if ( GM.score<=10)
        {
          forresurgence.SetActive(true);
          Debug.Log("Sorry, you cant take this! ");
          GM.GameOver();
        }
      
  }

  public void FiveMoreSeconds()
  {
        Time.timeScale = 1f ;
        GM.player.enabled = true;
        Cursor.visible = false;
       GM.gameOver.SetActive(false);
       GM.tryagainButton.SetActive(false);
       GM.score -=5;


        shoppingCanvas.gameObject.SetActive(false);
        
        StartCoroutine(FiveMoreSecondsPlayed());
  }

  IEnumerator FiveMoreSecondsPlayed()
  {
        yield return new WaitForSeconds(5);
        GM.GameOver();
  }

  public void IncreaseScore2()
  {
        Time.timeScale = 1f ;
        GM.player.enabled = true;
        Cursor.visible = false;
        

        
        GM.gameOver.SetActive(false);
        GM.tryagainButton.SetActive(false);
        if (GM.score>30)
        {
          GM.score -= 15;
          GM.score = GM.score*2;
          shoppingCanvas.gameObject.SetActive(false);
        }
        else if ( GM.score<=30)
        {
          Debug.Log("Sorry, you cant take this! ");
          forScore.SetActive(true);
         // StartCoroutine(WaitThreeSeconds());
          
          GM.GameOver();
        }
        
  }
   IEnumerator WaitThreeSeconds()
  {
        yield return new WaitForSeconds(3);
        
  }

  


}
