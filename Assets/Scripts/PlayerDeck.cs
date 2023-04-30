using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeck
{
    List<CardBase> witCards = new List<CardBase>();
    List<CardBase> stageCards = new List<CardBase>();
    List<CardBase> punchlineCards = new List<CardBase>();


    public void AddCard(CardBase card)
    {
       switch (card.CardType)
        {
            case CardType.witType:
                witCards.Add(card);
                break;

            case CardType.stageType:
                stageCards.Add(card);
                break;

            case CardType.punchlineType:
                punchlineCards.Add(card);
                break;
        }
    }


    public void RemoveCard(CardBase card)
    {
        switch (card.CardType)
        {
            // implement removal 
        }
    }

}
