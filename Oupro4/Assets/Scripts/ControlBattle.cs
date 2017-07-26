using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlBattle : MonoBehaviour
{
    public static int point = 0;
    public static int ATK;
    public static int DEF;
    public static int CHA=0;
    public static bool check = false;

    public void Battle()
    {
        if (check == false)
        {
            int rand = 0;
            point = CHA + 7;

            ATK = 0;
            DEF = 0;



            rand = Random.Range(1, point - 1);
            ATK = rand;
            Debug.Log(point + "-" + rand);
            point = point - rand;

            rand = Random.Range(1, point);
            DEF = rand;
            Debug.Log(point + "-" + rand);
            point = point - rand;

            CHA = point;
            check = true;
        }
    }

    public void Damage()
    {
        SelectCharacter.VIT = SelectCharacter.VIT - 1;
    }
}
