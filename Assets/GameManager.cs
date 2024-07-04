using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject AspawnP;
    public GameObject EspawnP;
    public GameObject BaseCard;
    public string[] corch;
    public WinsCounter EnemyCounter;
    public WinsCounter AllyCounter;
    public AttackManager MyAttackManager;

    // Start is called before the first frame update
    void Start()
    {
        SpawnACard();
        SpawnECard();
    }

    public void SpawnACard()
    {
        int position = Random.Range(0,corch.Length);
        Card newCard = GetComponent<CardFabric>().getNewCard(corch[position]);
        GameObject tempCard = Instantiate(BaseCard, AspawnP.transform);
        tempCard.GetComponent<CardDisplay>().SetCard(newCard);
        tempCard.GetComponent<CardStats>().SetStats(newCard);
        EnemyCounter.SetNewCard(tempCard.GetComponent<CardStats>());
        MyAttackManager.SetMYcard(tempCard.GetComponent<CardStats>());
        tempCard.GetComponent<CardStats>().OnDeath.AddListener(SpawnACard);

    }

     public void SpawnECard()
    {
        int position = Random.Range(0,corch.Length);
        Card newCard = GetComponent<CardFabric>().getNewCard(corch[position]);
        GameObject tempCard = Instantiate(BaseCard, EspawnP.transform);
        tempCard.GetComponent<CardDisplay>().SetCard(newCard);
        tempCard.GetComponent<CardStats>().SetStats(newCard);
        AllyCounter.SetNewCard(tempCard.GetComponent<CardStats>());
        MyAttackManager.SetEnecard(tempCard.GetComponent<CardStats>());
        tempCard.GetComponent<CardStats>().OnDeath.AddListener(SpawnECard);
    }
}
