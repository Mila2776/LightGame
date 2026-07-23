using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour, Interactable.ObjInteractable
{
    public RespawnManager respawnManager;
    
    private bool IsSaved = false;

    
    public void Interact()
    {
        Debug.Log("Checkpoint 被互動");

        if (IsSaved)
        {
            return;
        }
      
        respawnManager.SetCheckPoint(transform);

        IsSaved = true;

        Debug.Log("已存檔");
    }
}
