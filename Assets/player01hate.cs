using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class player01hate : MonoBehaviour
{
    [SerializeField]
    int add = 0;

    [SerializeField]
    Text player01text;

    [SerializeField]
    Text player02text;


    int NowPlayer01;
    int NowPlayer02;

    public void Awake()
    {
        NowPlayer01 = 0;
        NowPlayer02 = 0;

    }

    bool CountUpFlag = false;

    void Update()
    {
        //ジョイコン入力の場合
        //Input.GetKeyDown(KeyCode.Joystick1Button１)
        ////ジョイコン（Xボタンと十字キー↑
        if (Input.GetKeyDown(KeyCode.S))
        {
            NowPlayer01 += add;
            player01text.text = NowPlayer01.ToString();
        }
        if (Input.GetKeyDown(KeyCode.N))
        {
            NowPlayer02 += add;
            player02text.text = NowPlayer02.ToString();
        }

    }
}
