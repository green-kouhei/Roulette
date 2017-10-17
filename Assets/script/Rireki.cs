using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rireki : MonoBehaviour {
    public Text[] re;
    string[] st = { "", "", "", "", "", "", "", "", "" };



    public void printRireki(string num)
    {
        //re[0].text = num;
        for (int i = st.Length-1;i>0;i--)
        {
            st[i] = st[i - 1];
        }
        st[0] = num;
        for(int i = 0; i < re.Length; i++)
        {
            re[i].text = st[i];
        }

    }
}
