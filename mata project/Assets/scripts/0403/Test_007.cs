using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_007 : MonoBehaviour
{
    void SayHello()                                     //SayHello 함수를 선언
    {
        Debug.Log("Hello");                              //Hello 내용을 Console.log에 출력
    }
    void CallName(string name)
    {
        Debug.Log("Hello" + name);
    }

    int Add(int a,int b)                                //Add 함수 선언 
    {
        int c = a + b;                                  //c라는 int 변수 생성 a+b 값을 입력
        return c;                                       //값을 함수 반환 값으로 넘김(return)
    }

    // Start is called before the first frame update
    void Start()
    {
        SayHello();                                     //함수를 실행
        SayHello();                                     //함수를 실행
        CallName("TOM");                                //함수를 string 파라미터 Tom을 입력
        CallName("SAM");                                //함수를 string 파라미터 Sam을 입력
        int answer = Add(2, 5);                         //변수 int answer 선언하고 함수 의 반환값을 입력
        Debug.Log(answer);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
