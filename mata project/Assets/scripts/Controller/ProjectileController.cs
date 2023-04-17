using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileController : MonoBehaviour
{
    public GameObject Projectile;       //발사체 프리팹 선언

    public void FireProjectile()
    {
        GameObject temp = (GameObject)Instantiate(Projectile);

        temp.transform.position = this.gameObject.transform.position;

        temp.GetComponent<ProjectileMove>().launchDirection = transform.forward;

        Destroy(temp, 10.0f);
    }
}
