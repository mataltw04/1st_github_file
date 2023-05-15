using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileMove : MonoBehaviour
{
    public Vector3 launchDirection;

    public enum PROJECTILETYPE
    {
        PLAYER,
        ENEMY
    }

    public PROJECTILETYPE projectileType = PROJECTILETYPE.PLAYER;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Wall")
        {
            Destroy(this.gameObject);
        }

        if(collision.gameObject.tag == "Monster")
        {
            collision.gameObject.GetComponent<MonsterController>().Damanged(1);
            Destroy(this.gameObject);
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Wall")
        {
            Destroy(this.gameObject);
        }

        if (other.gameObject.tag == "Monster" && projectileType == PROJECTILETYPE.PLAYER)
        {
            other.gameObject.GetComponent<MonsterController>().Damanged(1);
            Destroy(this.gameObject);
        }
        if (other.gameObject.tag == "Player" && projectileType == PROJECTILETYPE.ENEMY)
        {
            other.gameObject.GetComponent<playerController>().Damanged(1);
            Destroy(this.gameObject);
        }
    }



    private void FixedUpdate()
    {
        float moveAmount = 3 * Time.fixedDeltaTime;

        transform.Translate(launchDirection * moveAmount);
    }
}
