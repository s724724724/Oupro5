using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeCard : MonoBehaviour {

    public RawImage CardType;
    public Texture[] Card;

    public void SelectCard()
    {
        switch (SelectCharacter.Card)
        {
            case 1:
                CardType.texture = Card[0];
                break;

            case 2:
                CardType.texture = Card[1];
                break;

            case 3:
                CardType.texture = Card[2];
                break;

            case 4:
                CardType.texture = Card[3];
                break;
        }


        //Debug.Log(SelectCharacter.Card);
    }
}