using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowStatus : MonoBehaviour {
    public Text text;
	// Update is called once per frame
	void Update () {
        text = this.GetComponent<Text>();
        text.text = SelectCharacter.VIT.ToString() + "\n" +
            SelectCharacter.DEX.ToString() + "\n" +
            SelectCharacter.POW.ToString() + "\n" +
            SelectCharacter.LUK.ToString() + "\n";
    }
}
