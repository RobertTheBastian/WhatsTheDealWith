using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CardZone : MonoBehaviour, IDropHandler
{


   //Triggers before OnEndDrag of the card class.
    public void OnDrop(PointerEventData eventData)
    {
        GameObject card = eventData.pointerDrag.gameObject;

        // make sure to check if its possible
          card.GetComponent<Card>().droppedOnZoneFlag = true;
          card.transform.SetParent(this.transform);
    }
}
