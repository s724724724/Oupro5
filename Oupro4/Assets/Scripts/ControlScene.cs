using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ControlScene : MonoBehaviour {
    bool statusText = true;
    public Text Message;
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //ステータスの決定
            SelectCharacter SC = GetComponent<SelectCharacter>();
            SC.SelectStatus();


            Message.GetComponent<Text>().enabled = false;
            
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            //ステータステキストの表示切替
            if (statusText == true)
            {
                GetComponent<Text>().enabled = false;
                statusText = false;
            }
            else
            {
                GetComponent<Text>().enabled = true;
                statusText = true;
            }
        }
    }
}
