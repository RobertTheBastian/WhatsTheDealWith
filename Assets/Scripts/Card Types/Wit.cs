using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New Wit Card",menuName = "Cards/Wit Card" )]
public class Wit : CardBase
{
    public bool variableDamage;

    public int minDamage;
    public int maxDamage;

    public float GetDamage()
    {
        if(variableDamage)
        {
            return 
        }
             else
        {
            return minDamage;
        }
    }
}
