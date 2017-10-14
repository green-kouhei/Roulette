using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rireki : MonoBehaviour {

GUIStyle guiStyle = new GUIStyle();
GUIStyleState styleState = new GUIStyleState();

void OnGUI () {

styleState.textColor = Color.green;
guiStyle.normal = styleState;

// ラベルを表示する
GUI.Label(new Rect(200, 200, 100, 50), "rireki", guiStyle);
}

}
