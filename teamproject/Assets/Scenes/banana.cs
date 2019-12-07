using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class banana : MonoBehaviour
{
    public GameObject bananaword;
    
    void OnMouseDown(){
    	if(grab2.inHand1){
    		Destroy(bananaword);
		}
    }
}