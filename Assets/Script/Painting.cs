using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Painting : MonoBehaviour
{
    public PuzzleManager puzzleManager;

    public bool IsInteracted = false;

    public void Interact(Candle candle)
    {
        if (candle.IsLightOn)
        {
            if (Input.GetKeyDown(KeyCode.L)) { 

                IsInteracted = true;

            }           
        
            if (IsInteracted)
            {
                Debug.Log("調查了畫");

                puzzleManager.Painting1Solved = true;

            }

        }
        
    }
}
