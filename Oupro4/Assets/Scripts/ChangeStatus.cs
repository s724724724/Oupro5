using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeStatus : MonoBehaviour {

    public void CardBonus()
    {
        switch (SelectCharacter.Card)
        {
            case 1:
                SelectCharacter.VIT = SelectCharacter.VIT + 1;
                break;

            case 2:
                SelectCharacter.DEX = SelectCharacter.DEX + 1;
                break;

            case 3:
                SelectCharacter.POW = SelectCharacter.POW + 1;
                break;

            case 4:
                SelectCharacter.LUK = SelectCharacter.LUK + 1;
                break;
        }
    }

}
