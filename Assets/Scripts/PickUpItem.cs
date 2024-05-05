using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUpItem : MonoBehaviour, IInteractable
{
    public string DisplaySprite;
    public enum property { usable, displayable };
    
    public string DisplayImage;

    private GameObject InventorySlots;
    public property itemProperty;
    public void Interact(DisplayImage currentDisplay)
    {
        ItemPickUp();
    }
    private void Start()
    {
        InventorySlots = GameObject.Find("Slots");
    }

   private void ItemPickUp()
    {
        foreach (Transform slot in InventorySlots.transform)
        {
            if (slot.transform.GetChild(0).GetComponent<Image>().sprite.name == "empty_item")
            {
                slot.transform.GetChild(0).GetComponent<Image>().sprite = Resources.Load<Sprite>("inventary items/" + DisplaySprite);
                slot.GetComponent<Slot>().AssignProperty((int)itemProperty, DisplayImage);
                Destroy(gameObject);
                break;
            }
        }
    }
}
