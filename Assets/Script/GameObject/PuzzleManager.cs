using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleManager : MonoBehaviour
{
    public bool Painting1Solved = false;
    

    public bool Statue1Solved = false;
    public bool Statue2Solved = false;

    public Door door1;
    public Door door2;


    // Update is called once per frame
    void Update()
    {
        CheckPuzzle();
    }
    public void PaintingSolved(int id)
    {
        switch (id)
        {
            case 1:
                Painting1Solved = true;
                break;

            default:
                Debug.LogWarning("沒有這幅畫 ID：" + id);
                break;
        }
    }

    public void StatueSolved(int id)
    {
        switch (id)
        {
            case 1:
                Statue1Solved = true;
                break;

            case 2:
                Debug.Log("第二個雕像已調查");
                Statue2Solved = true;
                break;

            default:
                Debug.LogWarning("沒有這個雕像 ID：" + id);
                break;
        }
    }

    void CheckPuzzle() {

        if (Painting1Solved && Statue1Solved)
        {

            door1.DoorOpen();

        }

        if (Statue2Solved)
        {

            door2.DoorOpen();

        }
    }
}
