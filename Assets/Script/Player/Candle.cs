using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Candle : MonoBehaviour
{
    public GameObject candleLight;
    public bool IsLightOn = false;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (IsLightOn) {

                Debug.Log("Light On");

            }

            if (!IsLightOn)
            {

                Debug.Log("Light Off");

            }

            ToggleLight();
        }
    }

    void ToggleLight()
    {
        IsLightOn = !IsLightOn;

        candleLight.SetActive(IsLightOn);

    }
}
