using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenController : MonoBehaviour
{
    public GameObject MonsterTemp;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(1))                 //���콺 �������� ��������
        {
            Ray cast = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit hit;                             // hit �������� ���� ����

            if(Physics.Raycast(cast,out hit))           //out�μ��� hit ���� ray�� ����� ���� �־��ش�
            {
                if(hit.collider.tag == "Ground")        //hit�Ѱ��� Tag�� Ground�˶� 
                {
                    GameObject temp = (GameObject)Instantiate(MonsterTemp);
                    temp.transform.position = hit.point + new Vector3(0.0f, 1.0f, 0.0f);

                }
                Debug.DrawLine(cast.origin, hit.point, Color.red, 2.0f);    //����� ���� ������ 2�ʵ��� �׷��ش�.
                Debug.Log("HIT =>" + hit.collider.name);        //hit�� ��ü�� name�� ������
            }
        }
    }
}
