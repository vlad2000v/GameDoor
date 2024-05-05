using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dynamic : MonoBehaviour, IInteractable
{

    public GameObject ChangedStateSprite;

    public enum InteractionProperty { simple_interaction, access_interaction }
    public InteractionProperty Property;

    public GameObject AccessObject;


    private GameObject inventory;


    void Start()
    {
        
        AccessObject.SetActive(false);
    }



    public void Interact(DisplayImage currentDisplay)
    {
                    if (Property == InteractionProperty.simple_interaction) return;
            inventory.GetComponent<inventory>().currentSelectedSlot.GetComponent<Slot>().ClearSlot();
            AccessObject.SetActive(true);
        }

    }

