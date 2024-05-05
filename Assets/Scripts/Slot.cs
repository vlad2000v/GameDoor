using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Slot : MonoBehaviour, IPointerClickHandler
{
    private GameObject inventory;

    public enum property { usable, displayable, empty};
    public property ItemProperty { get; set; }

    private string displayImage;
   public string combinationItem { get; private set; }

    void Start()
    {
        inventory = GameObject.Find("inventar");
    }


    public void OnPointerClick(PointerEventData eventData)
    {
        inventory.GetComponent<inventory>().previousSelectedSlot = inventory.GetComponent<inventory>().currentSelectedSlot;
        inventory.GetComponent<inventory>().currentSelectedSlot = this.gameObject;
        
        if (ItemProperty == Slot.property.displayable) DisplayItem();

    }

    internal void AssignProperty(int orderNumber, string displayImage)
    {
        ItemProperty = (property)orderNumber;
        this.displayImage = displayImage;
    }
    public void DisplayItem()
    {
        inventory.GetComponent<inventory>().itemDisplayer.SetActive(true);
        inventory.GetComponent<inventory>().itemDisplayer.GetComponent<Image>().sprite =
            Resources.Load<Sprite>("inventary items/" + displayImage);
    }

    public void ClearSlot()
    {
        ItemProperty = Slot.property.empty;
        displayImage = "";
        combinationItem = "";
        transform.GetChild(0).GetComponent<Image>().sprite =
            Resources.Load<Sprite>("inventary items/empty_item");
    }
}
