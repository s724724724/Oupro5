using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectCharacter : MonoBehaviour
{
    //初期に設定したステータスをそのまま別のクラスで使用できるようにしておく。
    //ここで設定した値は最低の数
    public static int VIT;
    public static int DEX;
    public static int POW;
    public static int LUK;
    public static int Card;
    public static bool selected = false;

    public void SelectStatus()
    {
        int rnum;
        VIT = 5;
        DEX = 5;
        POW = 5;
        LUK = 5;
        //残りポイント数
        int point = 20;
        int count = 4;

        //ステータスを割り振ったかどうかの確認
        bool vitc = false;
        bool dexc = false;
        bool powc = false;
        bool lukc = false;

        //全てのステータスが割り振られるまで繰り返す
        while(count != 0) {
            switch (Random.Range(1, 5))
            {
                case 1:
                    if (vitc == false)
                    {
                        count--;
                        rnum = Random.Range(1, point - count + 1);
                        VIT = VIT + rnum;
                        point = point - rnum;
                        vitc = true;
                        //Debug.Log(VIT);
                    }
                    break;

                case 2:
                    if (dexc == false)
                    {
                        count--;
                        rnum = Random.Range(1, point - count + 1);
                        DEX = DEX + rnum;
                        point = point - rnum;
                        dexc = true;
                        //Debug.Log(DEX);
                    }
                    break;

                case 3:
                    if (powc == false)
                    {
                        count--;
                        rnum = Random.Range(1, point - count + 1);
                        POW = POW + rnum;
                        point = point - rnum;
                        powc = true;
                        //Debug.Log(POW);
                    }
                    break;

                case 4:
                    if (lukc == false)
                    {
                        count--;
                        rnum = Random.Range(1, point - count + 1);
                        LUK = LUK + rnum;
                        point = point - rnum;
                        lukc = true;
                        //Debug.Log(LUK);
                    }
                    break;
            }
        }

        //一番高い値を保存する（カードを選ぶため）
        Card = 1;
        int max = VIT;

        if (max < DEX)
        {
            max = DEX;
            Card = 2;
        }
        if (max < POW)
        {
            max = POW;
            Card = 3;
        }
        if (max < LUK)
        {
            max = LUK;
            Card = 4;
        }

        //カードを選択した
        selected = true;
    }
}
