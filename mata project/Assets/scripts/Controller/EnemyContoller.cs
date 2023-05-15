using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyContoller : MonoBehaviour
{
    public float speed = 5.0f;          //적 속도

    public float rotationSpeed = 1f;    //포탑 회전 속도
    public GameObject bulletPrefab;     //총알 프리팹
    public GameObject EnemyPivot;       //적 피봇
    public Transform firePoint;         //발사 위치
    public float fireRate = 1f;         //연사 속도
    public float nextFireTime;

    private Rigidbody rb;
    private Transform player;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        GameObject Temp = GameObject.FindGameObjectWithTag("Player");

        if (Temp != null)
        {
            player = Temp.transform;
        }

    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(player.position , transform.position) > 5.0f)
        {
            Vector3 direction = (player.position - transform.position).normalized;
            rb.MovePosition(transform.position + direction * speed * Time.deltaTime);
        }

        Vector3 targetDirection = (player.position - EnemyPivot.transform.position).normalized;
        Quaternion targetRotation = Quaternion.LookRotation(targetDirection);
        EnemyPivot.transform.rotation = Quaternion.Lerp(EnemyPivot.transform.rotation,targetRotation,rotationSpeed * Time.deltaTime);

        if(Time.time > nextFireTime)
        {
            nextFireTime = Time.time + 1f / fireRate;
            GameObject temp = (GameObject)Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
            temp.GetComponent<ProjectileMove>().launchDirection = firePoint.localRotation * Vector3.forward;
            temp.GetComponent<ProjectileMove>().projectileType = ProjectileMove.PROJECTILETYPE.ENEMY;
        }
    }
}
