using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    public int level = 1;
    public GameObject[] closedlevel;

    private void Start()
    {
        level = PlayerPrefs.GetInt("level", level);
        for (int i = 0; i < level; i++)
        {
            closedlevel[i].SetActive(false);
        }
    }
   }

