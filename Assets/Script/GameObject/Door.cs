using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{

    public bool Opened = false;

    public void DoorOpen() { 
        
        if (Opened)
        {
            return;
        }

        Opened = true;

        Debug.Log("¶}ªù");

        gameObject.SetActive(false);

    }


}
