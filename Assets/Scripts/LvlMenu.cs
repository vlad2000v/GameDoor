using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LvlMenu : MonoBehaviour
{
    
    public Button[] buttons;
    private void Awake()
    {
        int unlockedlevel = PlayerPrefs.GetInt("UnlockedLevel", 1);
        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i].interactable = false;
        }
        for (int i = 0; i < unlockedlevel; i++)
        {
            buttons[i].interactable = true;
        }
    }
    public void Scenes(int numberScenes)
    {
        string levelName = "level1 " + numberScenes;
        SceneManager.LoadScene(numberScenes);

    }
}
