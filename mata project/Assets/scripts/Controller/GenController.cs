using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenController : MonoBehaviour
{
    public GameObject MonsterTemp;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(1))                 //마우스 오른쪽을 눌렀을때
        {
            Ray cast = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit hit;                             // hit 물리레이 변수 선언

            if(Physics.Raycast(cast,out hit))           //out인수로 hit 값에 ray값 검출된 값을 넣어준다
            {
                if(hit.collider.tag == "Ground")        //hit한곳의 Tag가 Ground알때 
                {
                    GameObject temp = (GameObject)Instantiate(MonsterTemp);
                    temp.transform.position = hit.point + new Vector3(0.0f, 1.0f, 0.0f);

                }
                Debug.DrawLine(cast.origin, hit.point, Color.red, 2.0f);    //디버그 빨강 라인을 2초동안 그려준다.
                Debug.Log("HIT =>" + hit.collider.name);        //hit된 물체에 name을 보여줌
            }
        }
    }
}
