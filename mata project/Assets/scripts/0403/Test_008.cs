using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player
{   
    private int hp = 100;                                       //hp�� �������� 100�� ���� �Է�
    private int Power = 50;                                     //power�� ������ �� 50�� ���� �Է�
    public void Attack()
    {
        Debug.Log(this.Power + "�������� �Ծ���.");            //this�� Player Ŭ������ �̾߱��Ѵ�.
    }
    public void Damage(int damage)                              //Damage �Լ��� int ���·� ���� ���̹� �μ��� �޴´�.
    {
        this.hp -= damage;
        Debug.Log(damage + "�������� �Ծ���.");
    }

    public int getHp()
    {
        return this.hp;
    }
}



public class Test_008 : MonoBehaviour
{
    Player player_01 = new Player();                            //���� ���� �÷��̾� Ŭ������ �����Ѵ�
    Player player_02 = new Player();                            //���� ���� �÷��̾� Ŭ������ �����Ѵ�
    public Text player01HP;                                     //�÷��̾� HP�� �����ִ� UI ����
    public Text player02HP;                                     //�÷��̾� HP�� �����ִ� UI ����

    // Start is called before the first frame update
    void Start()
    {                   
        player_01.Attack();                                     //������ player_01�� Attack �Լ��� �����Ų��.
        player_01.Damage(30);                                   //������ player_01�� Attack �Լ��� �����Ų��.(�μ� 30�� �־��ش�.)
    }

    // Update is called once per frame
    void Update()
    {
        player01HP.text = "Player 01 HP : " + player_01.getHp().ToString();
        player02HP.text = "Player 02 HP : " + player_02.getHp().ToString();

        if (Input.GetMouseButtonDown(0))
        {
            player_01.Damage(1);
        }
        if (Input.GetMouseButtonDown(1))
        {
            player_02.Damage(1);
        }
    }
}
