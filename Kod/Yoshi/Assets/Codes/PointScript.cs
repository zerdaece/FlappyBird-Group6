using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PointScript : MonoBehaviour
{
    public int Catpawns;
    public Text ScoreCatpawns;
    public GameObject gameoverscreen;

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
    }
}
