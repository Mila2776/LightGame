using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{

    public bool Opened = false;

    public void DoorOpen() { 
        
        if (Opened)
        {
            
            Opened = true;

            Debug.Log("Door Open");

            gameObject.SetActive(false);

        }
    
    
    
    
    
    }


}
