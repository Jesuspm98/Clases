using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardDisplay : MonoBehaviour
{
    public Card myCard;
    public Text cardNameText, cardDescriptionText, cardCostText, cardAttackText, cardDefenceText;
    public Image cardArtWork;

    private void Start()
    {
        cardNameText.text = myCard.cardName;
        cardCostText.text = myCard.cardCost.ToString();
        cardAttackText.text = myCard.cardAttack.ToString();
        cardDefenceText.text = myCard.cardDefence.ToString();
        cardDescriptionText.text = myCard.cardDescription;
        cardArtWork.sprite = myCard.cardArt;
    }
}