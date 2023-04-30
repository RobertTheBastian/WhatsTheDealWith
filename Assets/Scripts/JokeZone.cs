using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class JokeZone : MonoBehaviour, IDropHandler
{
    public bool isPunchline;

   //Triggers before OnEndDrag of the card class.
    public void OnDrop(PointerEventData eventData)
    {
        GameObject card = eventData.pointerDrag.gameObject;

        // make sure to check if its possible
          card.GetComponent<CardGameObject>().droppedOnZoneFlag = true;
          card.transform.SetParent(this.transform);
    }
}
