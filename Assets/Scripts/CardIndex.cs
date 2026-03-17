using UnityEngine;
using System.Collections.Generic;
 
namespace HarryGame
{
    [CreateAssetMenu(fileName = "New Card", menuName = "Card")]
    public class CardIndex : ScriptableObject
    {
        public string cardName;

        public string damage;

        public List<CardType> cardType;
    }

    public enum CardType
    {
        Attack,
        Skill,
        Power,
    }


}
