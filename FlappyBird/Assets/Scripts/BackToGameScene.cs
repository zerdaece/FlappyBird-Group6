
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToGameScene : MonoBehaviour
{
    
    public void changeScene()
    {
        SceneManager.LoadScene("SampleScene");
    }
    
    
}
