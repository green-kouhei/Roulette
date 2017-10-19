using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteOperation : MonoBehaviour {
    public float speed = 1500.0f;
    private GameObject mBall;
    private GameObject mBallClone;

    //スポット監視用変数
    private float mTimeElapsed;
    private int mLastIndex = -2;
    private bool mFlag = false;
    private string mNum = "";
    int[] NUMBERS = { -1, 27, 10, 25, 29, 12, 8, 19, 31, 18, 6, 21, 33, 16, 4, 23, 35, 14, 2, 0, 28, 9, 26, 30, 11, 7, 20, 32, 17, 5, 22, 34, 15, 3, 24, 36, 13, 1 };
    GUITest guiTest;
    Rigidbody roulette;

    private void Start()
    {
        mBall = GameObject.FindGameObjectWithTag("Player");
        guiTest = GameObject.Find("History").GetComponent<GUITest>();
        roulette = GameObject.Find("RotationBase").GetComponent<Rigidbody>();
    }
    
    void Update () {

        if (Input.GetKeyDown(KeyCode.Space)){
            //ルーレット回転処理
            roulette.velocity = Vector3.zero;
            roulette.AddTorque(Vector3.up * 4000.0f);

            //前回のボールを削除
            GameObject ballClone = GameObject.Find("golden_ball" + "(Clone)");
            if(ballClone != null)
            {
                Destroy(ballClone);
            }
            //ボールを打ち出す
            add_force();
        
        }


        //スポット監視
        int index = getSpotIndex();

        if (index != mLastIndex)
        {
            mTimeElapsed = 0;
            mLastIndex = index;
            mFlag = true;
            mNum = "-";
        }
        else
        {
            mTimeElapsed += Time.deltaTime;
            if (mTimeElapsed > 2.0f && mFlag)
            {
                if (index >= 0 && index < 38)
                {
                    mNum = NUMBERS[index].ToString();
                    mFlag = false;
                    guiTest.setNumber(mNum);
                }
            }
        }
    }



    public void add_force()
    {
        mBallClone = Instantiate(mBall, new Vector3(9.7f, 3.0f, -0.3f), mBall.transform.rotation);
        mBallClone.SetActive(true);
        Vector3 force = mBallClone.transform.forward.normalized * (speed * (Random.value * 0.1f + 0.9f));
        mBallClone.GetComponent<Rigidbody>().AddForce(force);
        //newball.GetComponent<Rigidbody>().AddTorque(-force);

    }


    int getSpotIndex()
    {
        GameObject board = GameObject.Find("kajino");
        if (mBallClone == null)
            return -2;
        Vector2 a = new Vector2(board.transform.position.x, board.transform.position.z);
        Vector2 b = new Vector2(mBallClone.transform.position.x, mBallClone.transform.position.z);

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


