using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUITest : MonoBehaviour {
    public GUIStyle headerStyle;
    public GUIStyle numberStyle;
    public int[] numbers = new int[9];
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnGUI()
    {
        int y = Screen.height-33*2;

        int width = 64;
        int height = 32;
        for(int i=0;i<9; i++)
        {
            GUI.Box(new Rect((width + 1) * i,y, width, height), (i + 1).ToString(), headerStyle);
            numberStyle.normal.textColor = new Color(1.0f, 0.0f, 0.0f);
            GUI.Box(new Rect((width + 1) * i,y+ height+1, width, height), numbers[i].ToString(), numberStyle);
        }
        
    }
}
