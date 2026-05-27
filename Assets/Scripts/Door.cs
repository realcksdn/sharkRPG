using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Door2D : MonoBehaviour, IInteractable
{
    //private bool isOpen = false;
   

    public void Interact()
    {

       
        //isOpen = !isOpen;
        //Debug.Log(isOpen ? "문이 열렸습니다." : "문이 닫혔습니다.");
        Debug.Log("들어감");
        FadeScript.fadeScript();
    }
}