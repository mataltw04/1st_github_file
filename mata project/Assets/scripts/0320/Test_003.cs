using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_003 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string str1 = "happy";          //string�� str1 ���� �� happy �� �Է�
        string str2 = "birthday";       //string�� str2 ���� �� birthday �� �Է�
        string message;                 //string�� message ����

        message = str1 + str2;          //message�� str1,str2 ���ڿ��� ����
        Debug.Log(message);             //console.log â�� message ���

        str1 += str2;                   //str = str1 + str2 �� ���
        Debug.Log(str1);                //console.log â�� str2 ���

        int num = 123;                  //int�� num ���� �� 123 �� �Է�
        message = str1 + num;           //message��
        Debug.Log(message);             //
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
