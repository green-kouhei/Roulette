
using UnityEngine;

public class GUITest : MonoBehaviour {
    public GUIStyle headerStyle; //ここのパラメータで背景の枠を変更可能
    public GUIStyle numberStyle;
    public string[] numbers = new string[9];

    static Color Red = new Color(255f / 255f, 0f / 255f, 0f / 255f);
    static Color Brack = new Color(0f / 255f, 0f / 255f, 0f / 255f);
    static Color White = new Color(255f / 255f, 255f / 255f, 255f / 255f);
    string[] RedNum = { "1", "3", "5", "7", "9", "12", "14", "16", "18", "21", "23", "25", "27", "30", "32", "34", "36" };
    Color[] co = { Brack, Brack, Brack, Brack, Brack, Brack, Brack, Brack, Brack };



    void OnGUI()
    {

        //枠の大きさ
        int width = 64;
        int height = 64;
        //位置計算
        int y = Screen.height- (height+1) * 2;
        for (int i=0;i<numbers.Length; i++)
        {
            GUI.Box(new Rect((width + 1) * i,y, width, height), (i + 1).ToString(), headerStyle);
            numberStyle.normal.textColor = co[i];//色はこんな感じで変更可能
            GUI.Box(new Rect((width + 1) * i,y+ height+1, width, height), numbers[i], numberStyle);
        }
        
    }

    public void printRireki(string num)
    {
        for (int i = numbers.Length-1;i>0;i--)
        {
            numbers[i] = numbers[i - 1];
            co[i] = co[i - 1];
        }



        if (num.Equals("-1"))
        {
            numbers[0] = "00";
            co[0] = White;
        }
        else
        {
                numbers[0] = num;
            for (int i = 0; RedNum.Length > i; i++)
            {
                if (num.Equals(RedNum[i]))
                {
                    co[0] = Red;
                    break;
                }
                co[0] = Brack;
            }

            if (num.Equals("0"))
            {
                co[0] = White;
            }

        }
        
    

    }

    public void reset() {
        numbers = new string[9];
    }


    }
