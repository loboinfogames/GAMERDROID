﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CAM_POINTER : MonoBehaviour, IPointerUpHandler, IPointerDownHandler
{
    //[HideInInspector]
    public bool Pressed;

    public void OnPointerDown(PointerEventData eventData)
    {
        Pressed = true;
    }
    public void OnPointerUp(PointerEventData eventData)
    {
        Pressed = false;
    }
}