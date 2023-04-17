using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public float moveSpeed = 6;                                     //���� �̵� ���ǵ� �����ϰ� ����
    public GameObject PlayerPivot;                                  //�þ߸� ��� ������ ������ �����ϱ� ���� ��ġ
    Camera viewCamera;                                              //���� ī�޶� �������� ���� ī�޶� Ŭ���� ����
    Vector3 velocity;                                               //�̵� ���� ���͸� ����
    public ProjectileController ProjectileController;               //�߻�ü Ŭ���� ����

    // Start is called before the first frame update
    void Start()
    {
        viewCamera = Camera.main;                                   //���� ī�޶� �������� ���ؼ� start���� ã�Ƽ� �Է�
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ProjectileController.FireProjectile();
        }    


        //��ǻ�� ȭ�� 2D�� ���콺��ǥ���� ī�޶� ����� �� 3D���������� ���콺 ��ġ ���� �������� ���ؼ�
        Vector3 mousePos = viewCamera.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, viewCamera.transform.position.y));
        
        //�÷��̾ ������ Ÿ�� ����Ʈ
        Vector3 targetPosition = new Vector3(mousePos.x, transform.position.y, mousePos.z);

        //�÷��̾� �Ǻ��� �ٶ���� �ϴ� ��ǥ�� ����
        PlayerPivot.transform.LookAt(targetPosition, Vector3.up);


        velocity = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")).normalized * moveSpeed;



    }
    private void FixedUpdate()
    {
        GetComponent<Rigidbody>().MovePosition(GetComponent<Rigidbody>().position + velocity * Time.fixedDeltaTime);
    }
}
