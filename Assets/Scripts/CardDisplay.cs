using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CardDisplay : MonoBehaviour {

	public Card card;

	public TextMeshProUGUI nameText;
	public TextMeshProUGUI descriptionText;

	public Image artworkImage;

	public TextMeshProUGUI manaText;
	public TextMeshProUGUI attackText;
	public TextMeshProUGUI healthText;

	// Use this for initialization
	 public void SetStats() {
		nameText.text = card.name;
		descriptionText.text = card.description;

		artworkImage.sprite = card.artwork;

		manaText.text = card.manaCost.ToString();
		attackText.text = card.attack.ToString();
		healthText.text = card.Maxhealth.ToString();
	}
	public void SetCard(Card NAME) 
	{
		card = NAME;
		SetStats();
	}
}
