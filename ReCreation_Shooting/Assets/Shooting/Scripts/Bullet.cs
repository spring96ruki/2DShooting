using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    public float BulletSpeed;
    public float EnemyBulletSpeed;

    Rigidbody2D rgd2D;

    // Use this for initialization
    void Start () {
        rgd2D = GetComponent<Rigidbody2D>();
        if (gameObject.tag == StringController.Name.PlayeBullet) {
            rgd2D.velocity = transform.up.normalized * BulletSpeed;
        } else if (gameObject.tag == StringController.Name.EnemyBullet) {
            rgd2D.velocity = transform.up.normalized * EnemyBulletSpeed;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == StringController.Name.DestroyArea)
        {
            Destroy(gameObject);
        }
    }
}
