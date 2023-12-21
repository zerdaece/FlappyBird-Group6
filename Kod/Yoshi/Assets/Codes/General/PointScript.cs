using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;
using Unity.VisualScripting;
using static UnityEditor.PlayerSettings;
using UnityEngine.Analytics;
using UnityEngine.SocialPlatforms.Impl;

public class PointScript : MonoBehaviour
{
    public float timer = 0;
    public float stopper = 7;
    public void Start()
    {
        Scps = GameObject.FindGameObjectWithTag("Player").GetComponent<CatScript>();
        Spawn = GameObject.FindGameObjectWithTag("spawner").GetComponent<TowerSpawner>();
        Bakron = GameObject.FindGameObjectWithTag("Background").GetComponent<Scrolling>();
        speed = GameObject.FindGameObjectWithTag("SP").GetComponent<Towerspeed>();
    }
    public void Update()
    {
        if (Scps.Highspeed == true)
        {
            pipe1 = GameObject.FindGameObjectsWithTag("Pipe");
            Cats.transform.position = new Vector3(-40, 0, -1);
            timer = timer + Time.deltaTime;
        }
        if (timer > stopper)
        {
            Debug.Log("agea");
            Scps.Highspeed = false;
            Scps.gameObject.GetComponent<Rigidbody2D>().isKinematic = false;
            Spawn.Spawnrate = 5;
            Bakron._x = 1 / 10;
            speed.towerspeed = 5;
        }
    }
    public int Catpawns;
    public Text ScoreCatpawns;
    public GameObject gameoverscreen;
    public GameObject taptostart;
    public GameObject background;
    public GameObject triggerb4game;
    public Scrolling Bakron;
    public GameObject ShieldPower;
    public GameObject Cats;
    public CatScript Scps;
    public TowerSpawner Spawn;
    public Towers Pipespeed;
    public Towerspeed speed;
    public GameObject[] pipe1;
    public bool shieldtruefalse = false;

    public GameObject playButton;
    public GameObject quitButton;
    public GameObject shopping;
    private float startTime;

    public GameObject playbuttonImage;
    public GameObject tryagainButton;

    [ContextMenu("asfsa")]
    public void addpawnscore(int addscore)
    {
        Catpawns = Catpawns + addscore;
        ScoreCatpawns.text = Catpawns.ToString();
    }
    public void addgoldpawnscore(int addgoldscore)
    {
        Catpawns = Catpawns + addgoldscore;
        ScoreCatpawns.text = Catpawns.ToString();
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameover()
    {
        gameoverscreen.SetActive(true);
        Spawn.Spawnrate = 9999;
        Bakron._x = 0;
        speed.towerspeed = 0;
    }
    public void shieldpower()
    {
        ShieldPower.SetActive(true);
        shieldtruefalse = true;
    }
    public void shieldlosing()
    {
        ShieldPower.SetActive(false);
        shieldtruefalse = false;
    }
    public void Speedincreasepower()
    {
        Scps.Highspeed = true;
        Scps.gameObject.GetComponent<Rigidbody2D>().isKinematic = true;
        Spawn.Spawnrate = 1;
        Bakron._x = 1;
        speed.towerspeed = 35;
    }
   public void startgame()
    {
        Debug.Log("sasf");
        speed.towerspeed = 10;
        Spawn.Spawnrate = 5;
        taptostart.SetActive(false);
        triggerb4game.SetActive(false);
    }

}