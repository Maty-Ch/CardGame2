using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WinsCounter : MonoBehaviour
{
    public CardStats Othercard;
    public TextMeshProUGUI MyCounter;
    private int Points = 0;

    void Start()
    {
        MyCounter = GetComponent<TextMeshProUGUI>();
    }

    public void SetNewCard(CardStats newCard)
    {
        Othercard = newCard;
        Othercard.OnDeath.AddListener(addPoint);
    }

    public void addPoint()
    {
        Points ++;
        MyCounter.text = Points.ToString();
    }
}
