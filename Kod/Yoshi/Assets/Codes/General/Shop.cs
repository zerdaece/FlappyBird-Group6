using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    public GameObject shoppingCanvas;
    public GameObject Scrollingshop;
    public GameManager GM;
    public PointScript Logic;
    public int newScoreforResurgence;
    public GameObject forScore;
    public GameObject forresurgence;
    public GameObject shopOpen;
    public GameObject ShopClose;
    public GameObject taptoplay;



    public void ShoppingMenu()
    {
        //SceneManager.LoadScene("Shopping");

        //Ortaya shopping canvas gelecek//
        shoppingCanvas.gameObject.SetActive(true);
        forScore.SetActive(false);
        forresurgence.SetActive(false);
        shoppingCanvas.SetActive(true);
        shopOpen.SetActive(false);
        ShopClose.SetActive(true);
        taptoplay.SetActive(false);
        
    }
    public void Shoppingclose()
    {
        shoppingCanvas.gameObject.SetActive(false);
        forScore.SetActive(false);
        forresurgence.SetActive(false);
        shoppingCanvas.SetActive(false);
        shopOpen.SetActive(true);
        ShopClose.SetActive(false);
        taptoplay.SetActive(true);
    }
    public void CloseShopMenu()
    {
        shoppingCanvas.gameObject.SetActive(false);

    }
    public void Resurgence()
    {
        Time.timeScale = 1f;
        GM.player.enabled = true;
        Cursor.visible = false;

        GM.gameOver.SetActive(false);
        GM.tryagainButton.SetActive(false);
        if (Logic.Catpawns > 10)
        {
            shoppingCanvas.gameObject.SetActive(false);
            Logic.Catpawns -= 10;
        }
        else if (Logic.Catpawns <= 10)
        {
            forresurgence.SetActive(true);
            Debug.Log("Sorry, you cant take this! ");
            GM.GameOver();
        }

    }

    public void FiveMoreSeconds()
    {
        Time.timeScale = 1f;
        GM.player.enabled = true;
        Cursor.visible = false;
        GM.gameOver.SetActive(false);
        GM.tryagainButton.SetActive(false);
        Logic.Catpawns -= 5;


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
        Time.timeScale = 1f;
        GM.player.enabled = true;
        Cursor.visible = false;



        GM.gameOver.SetActive(false);
        GM.tryagainButton.SetActive(false);
        if (GM.score > 30)
        {
            Logic.Catpawns -= 15;
            Logic.Catpawns = GM.score * 2;
            shoppingCanvas.gameObject.SetActive(false);
        }
        else if (Logic.Catpawns <= 30)
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
