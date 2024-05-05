﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ExitDoor : MonoBehaviour, IInteractable {

    public GameObject ChangedStateSprite;


    public string UnlockItem;

    public GameObject EscapeMessage;


    private GameObject inventory;


    void Start()
    {
        ChangedStateSprite.SetActive(false);
        inventory = GameObject.Find("inventar");

        
    }



    public void Interact(DisplayImage currentDisplay)
    {
        if (inventory.GetComponent<inventory>().currentSelectedSlot.gameObject.transform.GetChild(0).GetComponent<Image>().sprite.name == UnlockItem || UnlockItem == "")
        {
            ChangedStateSprite.SetActive(true);
            this.gameObject.layer = 2;


            Instantiate(EscapeMessage, GameObject.Find("Canvas").transform);

            currentDisplay.CurrentState = DisplayImage.State.idle;
            


            
        }

    }
   
}
