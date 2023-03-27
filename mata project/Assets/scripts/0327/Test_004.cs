using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Test_004 : MonoBehaviour
{
    public int hp = 180;            //변수 hp 선언 180 값 입력 
    public Text hpText;
    public Text hpStatus;

    

    // Update is called once per frame
    void Update()
    {
        hpStatus.text = hp.ToString();


        if(Input.GetMouseButtonDown(0))
        {
            hp += 10;
        }
        if(Input.GetMouseButtonDown(1))
        {
            hp -= 10;
        }



        if (hp <= 50)                //변수 hp가 50 이하일 때
        {
            //Debug.Log("도망!");       //console.Log창에 도망이라고 나오게 한다.
            hpText.text = "도망!";
        }
        else if (hp >= 200)
        {
            //Debug.Log("공격!");       //console.Log창에 공격이라고 나오게 한다.
            hpText.text = "공격!";
        }
        else
        {
            //Debug.Log("방어!");       //console.Log창에 방어라고 나오게 한다.
            hpText.text = "방어!";
        }
    }
}
