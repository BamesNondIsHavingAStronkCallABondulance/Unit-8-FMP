using UnityEngine;
using HarryGame;
using UnityEngine.UI;
using TMPro;

public class CardDisplay : MonoBehaviour
{

    public CardIndex cardData;
    public Image[] cardArt;

    public Image cardImage;
    public TMP_Text nameText;
    public TMP_Text typeText;
    public TMP_Text cardDescription;

    private Color[] typeColours =
    {
        Color.red, //attack
        Color.blue, //skill
        Color.yellow, //power
    };

    void Start()
    {
        UpdateCardDisplay();   
    }

    public void UpdateCardDisplay()
    {
        cardImage.color = typeColours[(int)cardData.cardType[0]];
        nameText.text = cardData.cardName;
        typeText.text = cardData.cardType[0].ToString();
        cardDescription.text = cardData.cardDescriptions[0].ToString();
    }


}
