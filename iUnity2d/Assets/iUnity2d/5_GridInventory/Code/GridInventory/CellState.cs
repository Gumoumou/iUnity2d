﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CellState : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

    public Vector2Int CellPos;
    public bool isFree = true;

    public GridManager _GridManager;    //在生成cell的时候 赋值了。

    private UnityEngine.UI.Image _CellImage;

    private void Awake()
    {
        _CellImage = gameObject.GetComponent<UnityEngine.UI.Image>();
    }

    void Start () {
	}

    public void OnPointerEnter(UnityEngine.EventSystems.PointerEventData eventData)
    {
        _GridManager.CurrentCell = this;
    }
    public void OnPointerExit(UnityEngine.EventSystems.PointerEventData eventData)
    {
        _GridManager.CurrentCell = null;
    }

    public void SetColor(Color newColor)
    {
        _CellImage.color = newColor;
    }

}
