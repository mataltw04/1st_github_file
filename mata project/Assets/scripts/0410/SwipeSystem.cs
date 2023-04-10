using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeSystem : MonoBehaviour
{
    private Vector2 initialPos;
    public GameObject Character;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) initialPos = Input.mousePosition;               //������ �� ���콺 ��ġ�� �����Ѵ�
        if (Input.GetMouseButtonUp(0)) Calculate(Input.mousePosition);                  //���콺�� Up�Ǿ����� �μ��δ� ���콺 ��ġ�� �Է��ϰ� �Լ��� ȣ���Ѵ�.

    }

    void Calculate(Vector3 finalPos)
    {
        float disX = Mathf.Abs(initialPos.x - finalPos.x);                   //���밪 (Mathf.Abs) disX�� distance�� ���� (�Ÿ�)
        float disY = Mathf.Abs(initialPos.y - finalPos.y);

        if (disX > 0 || disY > 0)                                           // || = or
        {
            if(disX > disY)                                                 //������� �������� �˻��ؼ� ū���� �Ǵ�
            {
                if (initialPos.x > finalPos.x)
                {
                    Character.transform.position += new Vector3(-1.0f, 0.0f, 0.0f);
                }
                else
                {
                    Character.transform.position += new Vector3(1.0f, 0.0f, 0.0f);
                }
            }
            else
            {
                if (initialPos.y > finalPos.y)
                {
                    Character.transform.position += new Vector3(0.0f, 0.0f, -1.0f);
                }
                else
                {
                    Character.transform.position += new Vector3(0.0f, 0.0f, 1.0f);
                }
            }
        }


    }
}
