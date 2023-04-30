using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CardGameObject : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{

   private Vector2   dragOffset;
   public  Transform handPanel;
   public  bool droppedOnZoneFlag;
   public CardBase card;


    public void Start()
    {
        handPanel = GameObject.Find("Hand Panel").transform;
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        dragOffset =    transform.position;
        dragOffset.x -= eventData.position.x;
        dragOffset.y -= eventData.position.y;
        transform.SetParent(GameObject.Find("Canvas").transform);

        GetComponent<CanvasGroup>().blocksRaycasts = false;
    }


    public void OnDrag(PointerEventData eventData)
    {
        transform.position = eventData.position + dragOffset;
    }



    void IEndDragHandler.OnEndDrag(PointerEventData eventData)
    {
        if(!droppedOnZoneFlag)
        {
            this.transform.SetParent(handPanel);
        }
        droppedOnZoneFlag = false;

        GetComponent<CanvasGroup>().blocksRaycasts = true;
    }
}
