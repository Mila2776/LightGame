using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Painting : MonoBehaviour, Interactable.interactable
{
    public PuzzleManager puzzleManager;

    public bool IsInteracted = false;

    public void Interact()
    {

      Debug.Log("調查了畫");

      puzzleManager.Painting1Solved = true;

    }

}
