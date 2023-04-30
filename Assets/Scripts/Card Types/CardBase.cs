using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class CardBase : ScriptableObject
{
    public Sprite cardArtwork;
    public string cardName;
    public string cardFlavour;
    public CardType cardType;
    public CardTheme cardTheme;
}

public enum CardTheme
{
    black,
    blue,
    white
}

public enum CardType
{
    witType,
    stageType,
    punchlineType
}
