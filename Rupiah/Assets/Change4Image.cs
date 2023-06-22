using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Change4Image : MonoBehaviour
{
    public Image original;
    public Sprite infopahlawan1;
    public Sprite infopahlawan2;
    public Sprite infotari;
    public Sprite infolokasi;
    public int num = 0;
    
    void Start(){
        infopahlawan1 = original.sprite;
    }

    void Update(){
        
    }

    public void WhenButtonClicked(){
        num++;
        if(num == 1){
           original.sprite = infopahlawan2;
        }
        
        if(num == 2){
           original.sprite = infotari;
        }
        
        if(num == 3){
           original.sprite = infolokasi;
        }

        if(num == 4){
           original.sprite = infopahlawan1;
           num = 0;
        }
    }
}