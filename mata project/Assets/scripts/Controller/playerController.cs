using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public float moveSpeed = 6;                                     //변수 이동 스피드 조절하게 선언
    public GameObject PlayerPivot;                                  //시야를 어느 각도로 보는지 설정하기 위한 위치
    Camera viewCamera;                                              //메인 카메라를 가져오기 위한 카메라 클래스 선언
    Vector3 velocity;                                               //이동 방향 벡터를 선언
    public ProjectileController ProjectileController;               //발사체 클래스 선언

    // Start is called before the first frame update
    void Start()
    {
        viewCamera = Camera.main;                                   //메인 카메라를 가져오기 위해서 start에서 찾아서 입력
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ProjectileController.FireProjectile();
        }    


        //컴퓨터 화묜 2D의 마우스좌표에서 카메라를 통과한 후 3D영역에서의 마우스 위치 값을 가져오기 위해서
        Vector3 mousePos = viewCamera.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, viewCamera.transform.position.y));
        
        //플레이어가 봐야할 타겟 포인트
        Vector3 targetPosition = new Vector3(mousePos.x, transform.position.y, mousePos.z);

        //플레이어 피봇이 바라봐야 하는 좌표를 설정
        PlayerPivot.transform.LookAt(targetPosition, Vector3.up);


        velocity = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")).normalized * moveSpeed;



    }
    private void FixedUpdate()
    {
        GetComponent<Rigidbody>().MovePosition(GetComponent<Rigidbody>().position + velocity * Time.fixedDeltaTime);
    }
}
