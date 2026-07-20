using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleManager : MonoBehaviour
{
    public bool Painting1Solved = false;
    public bool Statue1Solved = false;

    public Door door1;

    // Update is called once per frame
    void Update()
    {
        CheckPuzzle();
    }

    void CheckPuzzle() {

        if (Painting1Solved && Statue1Solved)
        {

            door1.DoorOpen();

        }
    }
}
