using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Statue : MonoBehaviour, Interactable.interactable
{
    public PuzzleManager puzzleManager;

    public bool IsInteracted = false;

    public void Interact()
    {
        Debug.Log("調查了雕像");

        Debug.Log(puzzleManager);

        puzzleManager.Statue1Solved = true;


    }
}
