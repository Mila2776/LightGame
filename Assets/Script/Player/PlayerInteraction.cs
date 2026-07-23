using System.Collections;
using System.Collections.Generic;
using Unity.Burst.CompilerServices;
using UnityEngine;
using static Interactable;

public class PlayerInteraction : MonoBehaviour
{
    public Candle CandleSystem;

    public Interactable CurrentInteractable;

    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 MousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            RaycastHit2D hit = Physics2D.Raycast(MousePos, Vector2.zero);

            Interactable obj = hit.collider.GetComponentInParent<Interactable>();

            if (obj.NeedLight && !CandleSystem.IsLightOn)
            {
                Debug.Log("太黑了，什麼都看不見...");
                return;

            }
            else
            {
                
                if (obj != null)
                {
                    float distance = Vector2.Distance(transform.position, obj.InteractionPoint.position);

                    if (distance <= obj.InteractDistance)
                    {
                        Interactable.ObjInteractable interactable = hit.collider.GetComponentInParent<Interactable.ObjInteractable>();

                        if (interactable != null)
                        {
                            interactable.Interact();
                        }

                    }

                }

            }

        }
    }
}
