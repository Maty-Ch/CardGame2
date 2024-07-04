using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CardStats : MonoBehaviour, IDamageble

{
   int maxhealth;
   int health;
   int mana;
   int damage;
   public UnityEvent OnDeath = new UnityEvent();
   public CardDisplay mycardDisplay;
   
   public void SetStats(Card card)
   {
        maxhealth = card.Maxhealth;
        health = maxhealth;
        mana = card.manaCost;
        damage = card.attack;
   }

   public void GetDamage(int damage)
   {
        health -= damage;
        if(health <= 0)
        {
            health = 0;
            OnDeath.Invoke();
            Destroy(this);
        }
        mycardDisplay.healthText.text = health.ToString();
   }

   public void DoDamage(CardStats EnemyCard)
   {
        EnemyCard.GetDamage(damage);
   }

}
