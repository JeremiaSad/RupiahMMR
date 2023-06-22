using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Change3Image : MonoBehaviour
{
    public Image original;
    public Sprite infopahlawan;
    public Sprite infotari;
    public Sprite infolokasi;
    public int num = 0;
    
    void Start(){
        infopahlawan = original.sprite;
    }

    void Update(){
        
    }

    public void WhenButtonClicked(){
        num++;
        if(num == 1){
           original.sprite = infotari;
        }
        
        if(num == 2){
           original.sprite = infolokasi;
        }
        
        if(num == 3){
           original.sprite = infopahlawan;
           num = 0;
        }
    }
}