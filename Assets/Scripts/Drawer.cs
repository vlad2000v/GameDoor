using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Drawer : MonoBehaviour, IInteractable
{
    public string UnlockItem;
    private GameObject inventory;

    void Start () {
        inventory = GameObject.Find("inventar");
    }
    public void Interact(DisplayImage currentDisplay)
    {
        if (inventory.GetComponent<inventory>().currentSelectedSlot.gameObject.transform.GetChild(0).
            GetComponent<Image>().sprite.name == UnlockItem)
        {
            Debug.Log("Unloc");
            inventory.GetComponent<inventory>().currentSelectedSlot.GetComponent<Slot>().ItemProperty = Slot.property.empty;
            inventory.GetComponent<inventory>().currentSelectedSlot.gameObject.transform.GetChild(0).GetComponent<Image>().sprite =
                Resources.Load<Sprite>("inventary items/empty_item");


        }
    }
}
