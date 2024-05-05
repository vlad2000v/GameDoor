using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLvl : MonoBehaviour
{
    public void Finish()
    {
        int currentlevel = SceneManager.GetActiveScene().buildIndex;
        if (currentlevel >- PlayerPrefs.GetInt ("UnlockedLevel"))
        {
            PlayerPrefs.SetInt("UnlockedLevel", currentlevel + 1);
        }
        SceneManager.LoadScene(0);

    }
}
