using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    public Transform InteractionPoint;
    //互動距離
    public float InteractDistance = 2f;
    //是否需要蠟燭才能互動
    public bool NeedLight = true;
    public interface ObjInteractable
    {
        void Interact();
    }
}
