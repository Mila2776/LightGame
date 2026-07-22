using System.Collections;
using System.Collections.Generic;
using Unity.Burst.CompilerServices;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    public Candle CandleSystem;

    public Interactable CurrentInteractable;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

            if (CandleSystem.IsLightOn)
            {
                Vector2 MousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

                RaycastHit2D hit = Physics2D.Raycast(MousePos, Vector2.zero);


                if (hit.collider != null)
                {
                    Debug.Log("點到了：" + hit.collider.name);

                    Interactable.interactable interactable = hit.collider.GetComponentInParent<Interactable.interactable>();

                    if (interactable != null)
                    {
                        interactable.Interact();
                    }
                }
            }
            else
            {
                Debug.Log("太黑了，什麼都看不見...");
                return;
            }

        }
    }
}
