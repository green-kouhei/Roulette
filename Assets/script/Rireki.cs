using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rireki : MonoBehaviour {
    public Text[] re;
    string[] st = { "", "", "", "", "", "", "", "", "" };
    static Color Red = new Color(255f / 255f, 0f / 255f, 0f / 255f);
    static Color Brack = new Color(0f / 255f, 0f / 255f, 0f / 255f);
    static Color White = new Color(255f / 255f, 255f / 255f, 255f / 255f);
    string[] RedNum = { "1", "3", "5", "7", "9", "12", "14", "16", "18" ,"21","23","25","27","30","32","34","36"};
    Color[] co = { Brack, Brack , Brack , Brack , Brack , Brack , Brack , Brack , Brack };

    public void printRireki(string num)
    {
        //re[0].text = num;
        for (int i = st.Length - 1; i > 0; i--)
        {
            st[i] = st[i - 1];
            co[i] = co[i - 1];
        }


        if (num.Equals("-1")){
            st[0] = "00";
            co[0] = White;
        }
        else {
            st[0] = num;
            for (int i = 0;RedNum.Length>i;i++){
                if (num.Equals(RedNum[i])){
                    co[0] = Red;
                    break;
                }
                co[0] = Brack;
            }

        }



        for(int i = 0; i < re.Length; i++)
        {
            re[i].text = st[i];
            re[i].color = co[i];
        }



    }
}
