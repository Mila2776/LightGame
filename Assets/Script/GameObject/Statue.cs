using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Statue : MonoBehaviour, Interactable.ObjInteractable
{
    public PuzzleManager puzzleManager;

    public int StatueID;

    public bool IsInteracted = false;

    public void Interact()
    {
        if (IsInteracted)
        {

            return;

        }

        IsInteracted = true;

        Debug.Log("調查了第" + StatueID + "個雕像");


        puzzleManager.StatueSolved(StatueID);

    }
}
