using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Test_004 : MonoBehaviour
{
    public int hp = 180;            //���� hp ���� 180 �� �Է� 
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



        if (hp <= 50)                //���� hp�� 50 ������ ��
        {
            //Debug.Log("����!");       //console.Logâ�� �����̶�� ������ �Ѵ�.
            hpText.text = "����!";
        }
        else if (hp >= 200)
        {
            //Debug.Log("����!");       //console.Logâ�� �����̶�� ������ �Ѵ�.
            hpText.text = "����!";
        }
        else
        {
            //Debug.Log("���!");       //console.Logâ�� ����� ������ �Ѵ�.
            hpText.text = "���!";
        }
    }
}
