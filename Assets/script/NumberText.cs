using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumberText : MonoBehaviour {
    private float mTimeElapsed;
    private int mLastIndex = -2;
    private bool mFlag = false;
    private string mNum="";

    int[] NUMBERS = { -1, 27, 10, 25, 29, 12, 8, 19, 31, 18, 6, 21, 33, 16, 4, 23, 35, 14, 2, 0, 28, 9, 26, 30, 11, 7, 20, 32, 17, 5, 22, 34, 15, 3, 24, 36, 13, 1 };
    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        int index = getSpotIndex();

        if(index != mLastIndex)
        {
            mTimeElapsed = 0;
            mLastIndex = index;
            mFlag = true;
            mNum = "-";
        }
        else 
        {
            mTimeElapsed += Time.deltaTime;
            if(mTimeElapsed > 2.0f && mFlag)
            {
                if (index >= 0 && index < 38)
                {
                    mNum = NUMBERS[index].ToString();
                    mFlag = false;
                }
            }
        }
        Text text = GetComponent<Text>();
        text.text = mNum;

    }
    int getSpotIndex()
    {
        GameObject board = GameObject.Find("kajino");
        GameObject ball = GameObject.Find("golden_ball" + "(Clone)");
        if (ball == null)
            return -2;
        Vector2 a = new Vector2(board.transform.position.x, board.transform.position.z);
        Vector2 b = new Vector2(ball.transform.position.x, ball.transform.position.z);

        float boardRot = board.transform.eulerAngles.y;
        float r = (int)(getAngle(b, a) - boardRot - 90.0f);
        r = ((int)r + 720) % 360;

        float p = 360.0f / 38.0f;
        return (int)((r + p * 0.5f) / p);
    }
    static float getAngle(Vector2 p1, Vector2 p2)
    {
        float dx = p2.x - p1.x;
        float dy = p2.y - p1.y;
        float rad = Mathf.Atan2(dy, dx);
        return -rad * Mathf.Rad2Deg;
    }
}
