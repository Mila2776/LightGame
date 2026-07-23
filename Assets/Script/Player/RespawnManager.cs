using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnManager : MonoBehaviour
{
    public Transform Player;
    public Transform FristRespawnPoint;
    public Transform CurrentCheckPoint;

    void Start()
    {
        CurrentCheckPoint = FristRespawnPoint;
    }

    public void SetCheckPoint(Transform CheckPoint) {

        CurrentCheckPoint = CheckPoint;

        Debug.Log("存檔成功" + CheckPoint.name);

    }

    public void RespawnPlayer()
    {
        if (CurrentCheckPoint != null)
        {

            Player.position = CurrentCheckPoint.position;

        }
        else {


            Debug.Log("沒設定存檔點");
        
        
        }



    }

}
