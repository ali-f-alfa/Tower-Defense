﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragDropMenu : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    [SerializeField] private Canvas canvas;
    private RectTransform rectTransform;
    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("DOWN");
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("BEGIN");
    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("ON");
        rectTransform.anchoredPosition += eventData.delta  / canvas.scaleFactor;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        // Here we have to initiate a prefab
        // Then we have to set the little image back to its place 
        Debug.Log("END");
    }

}
