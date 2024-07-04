using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AttackManager : MonoBehaviour
{
    CardStats MyCard;
    CardStats EnemyCard;
    public Button MyButton;

    public IEnumerator AttackCoroutine()
    {
        MyButton.interactable = false;
        MyCard.DoDamage(EnemyCard);
        yield return new WaitForSeconds(1);
        EnemyCard.DoDamage(MyCard);
        yield return new WaitForSeconds(1);
        MyButton.interactable = true;
    }

    public void stopAttack()
    {
        StopAllCoroutines();
        MyButton.interactable = true;
    }

    public void StartAttack()
    {
        StartCoroutine(AttackCoroutine());
    }

    public void SetMYcard(CardStats newCard)
    {
        MyCard = newCard;
        MyCard.OnDeath.AddListener(stopAttack);

    }
    public void SetEnecard(CardStats newCard)
    {
        EnemyCard = newCard;
        EnemyCard.OnDeath.AddListener(stopAttack);
        
    }
}   

