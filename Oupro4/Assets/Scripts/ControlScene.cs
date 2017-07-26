using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ControlScene : MonoBehaviour
{
    bool statusText = true;
    bool cardBonus = false;
    public Text message;
    int point = 0;
    bool live = true;


    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space) && (SelectCharacter.selected == false))
        {
            //ステータスの決定
            SelectCharacter SC = GetComponent<SelectCharacter>();
            SC.SelectStatus();


            message.text = "";

        }

        //ステータステキストの表示切替
        if (Input.GetKeyDown(KeyCode.S))
        {
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

        //カード選択後かつ回転が止まった後
        if ((SelectCharacter.selected == true)&& (RotateCard.check == true))
        {
            //ボーナスポイント未確定中
            if (cardBonus == false)
            {
                message.text = "ボーナスポイントを入力してください\n" +
                                "入力方法：ポイント分「Space」を押し「Enter」で確定\n" +
                                "ボーナスポイント：" + point;
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    ChangeStatus CS = GetComponent<ChangeStatus>();
                    CS.CardBonus();
                    point++;
                }


                if (Input.GetKeyDown(KeyCode.Return))
                {
                    cardBonus = true;
                    message.text = "";
                }
            }

            //ボーナスポイント確定後
            if (cardBonus == true && (live == true))
            {
                ControlBattle CB = GetComponent<ControlBattle>();
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    CB.Damage();
                }
                else if (Input.GetKeyDown(KeyCode.Return))
                {
                    CB.Battle();
                    ControlBattle.check = false;
                }

                message.text = "ATK" + ControlBattle.ATK + "\n" +
                               "DEF" + ControlBattle.DEF + "\n" +
                               "CHA" + ControlBattle.CHA;

                if(SelectCharacter.VIT < 1)
                {
                    live = false;
                }
            }
            
            if(live == false)
            {

                GameObject.Find("Main Camera").GetComponent<Camera>().backgroundColor = new Color(0.2f, 0.1f, 0.1f, 1.0f);
            }
        }
    }

}
