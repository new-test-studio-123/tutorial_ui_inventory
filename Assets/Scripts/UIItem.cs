using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIItem : MonoBehaviour
{

    public Item item;
    private Image spriteImage;


    void Awake() {
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
    
}
