﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class BT_DASH : MonoBehaviour
{
    // [HideInInspector]
    public bool Pressed;

    void Start()
    {

    }

    void Update()
    {

    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Pressed = true;

    }
    public void OnPointerUp(PointerEventData eventData)
    {
        Pressed = false;
    }
}
