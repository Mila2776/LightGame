using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Painting : MonoBehaviour, Interactable.interactable
{
    public PuzzleManager puzzleManager;

    public int PaintingID;

    private bool IsInteracted = false;

    public void Interact()
    {
        if (IsInteracted) {

            return;
        
        }

        IsInteracted = true;

        Debug.Log("調查了第" + PaintingID + "幅畫");

        puzzleManager.PaintingSolved(PaintingID);

    }

}
