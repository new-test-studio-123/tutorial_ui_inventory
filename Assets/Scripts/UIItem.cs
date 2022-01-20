using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class UIItem : MonoBehaviour, IPointerDownHandler
{

    public Item item;
    private Image spriteImage;
    private UIItem selectedItem;


    void Awake() {
        selectedItem = GameObject.Find("SelectedItem").GetComponent<UIItem>();
        spriteImage = GetComponent<Image>();
        Debug.Log("SpriteImage :" + spriteImage);
        UpdateItem(null);
    }

    public void UpdateItem(Item item) {
        this.item = item;
        if(this.item != null) {
            spriteImage.color = Color.white;
            //Debug.Log("Item ddfdfd " + this.item.title);
            spriteImage.sprite = item.icon;
             Debug.Log("Item ddfdfd " + this.item);
        }
        else {
            spriteImage.color = Color.clear;
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
       if (this.item != null){
          if(selectedItem.item != null){
              Item clone  = new Item(selectedItem.item);
              selectedItem.UpdateItem(this.item);
              UpdateItem(clone);
          } else {
              selectedItem.UpdateItem(this.item);
              UpdateItem(null);
          }
       } else if (selectedItem.item != null) {
           UpdateItem(selectedItem.item);
           selectedItem.UpdateItem(null);
       }
    }
}
