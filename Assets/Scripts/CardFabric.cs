using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardFabric : MonoBehaviour
{
   public Card[] MyCards;

   public Card getNewCard(string name)
   {
    foreach(Card card in MyCards)
    {
        if(card.name == name)
        {
            return card;
        }
    }
    return null;
   }
}
