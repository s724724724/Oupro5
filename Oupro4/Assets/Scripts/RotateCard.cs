using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCard : MonoBehaviour {
    bool waiting = true;        //待機中かどうか確認
    bool selectedCard = false;  //カードが決定されたかどうかの確認
    bool lastRotate = false;
    bool check = false;
    float rotateSpeed = 3;
    float time;

    void Start()
    {
        time = 0;
    }

    void Update () {
        //回転
        transform.Rotate(new Vector3(0, rotateSpeed, 0));

        //最初の入力待機中の回転速度
        if (waiting == true)
        {
            rotateSpeed = 3;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            waiting = false;        //待機中ではない
        }


        //待機画面から変わった場合
        if (waiting == false)
        {
            time += Time.deltaTime; //毎フレームの時間を加算
            selectedCard = true;    //カードが決定された

            //最初の3秒間だけカードの回転速度が加速し
            if (time <= 1)   
            {
                rotateSpeed++;
            }
            else if ((2 < time) && (time < 3))
            {
                //カードの変更
                ChangeCard CC = GetComponent<ChangeCard>();
                CC.SelectCard();
            }
            //変更後減速する
            else if ((3 < time) && (time <= 4))
            {
                rotateSpeed--;
            }
            else if ((4 < time) && (time <= 5))
            {
                rotateSpeed = rotateSpeed / 1.1f;
                lastRotate = true;
            }

            //カードを正面に向ける
            if (lastRotate == true)
            {
                if (check == false)
                {
                    rotateSpeed = 1;
                    if ((transform.localEulerAngles.y <=1) || (359 <= transform.localEulerAngles.y))
                    {
                        check = true;
                    }
                }
                else if (check == true)
                {
                    rotateSpeed = 0;
                }
            }
        }
    }
}
