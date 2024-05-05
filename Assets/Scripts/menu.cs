using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class menu : MonoBehaviour
{
    
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
   
    public void Scenes(int numberScenes)
    {
        SceneManager.LoadScene(numberScenes);

    }
    public void Exitgame()
    {
        Application.Quit();
    }

}
