using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_007 : MonoBehaviour
{
    void SayHello()                                     //SayHello �Լ��� ����
    {
        Debug.Log("Hello");                              //Hello ������ Console.log�� ���
    }
    void CallName(string name)
    {
        Debug.Log("Hello" + name);
    }

    int Add(int a,int b)                                //Add �Լ� ���� 
    {
        int c = a + b;                                  //c��� int ���� ���� a+b ���� �Է�
        return c;                                       //���� �Լ� ��ȯ ������ �ѱ�(return)
    }

    // Start is called before the first frame update
    void Start()
    {
        SayHello();                                     //�Լ��� ����
        SayHello();                                     //�Լ��� ����
        CallName("TOM");                                //�Լ��� string �Ķ���� Tom�� �Է�
        CallName("SAM");                                //�Լ��� string �Ķ���� Sam�� �Է�
        int answer = Add(2, 5);                         //���� int answer �����ϰ� �Լ� �� ��ȯ���� �Է�
        Debug.Log(answer);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}