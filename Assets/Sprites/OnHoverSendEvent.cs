using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class OnHoverSendEvent : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameEvent hoverButtonStart;
    public GameEvent HoverButtonEnd;
    public void OnPointerEnter(PointerEventData eventData)
    {
        hoverButtonStart.Raise();
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        HoverButtonEnd.Raise();
    }
}
