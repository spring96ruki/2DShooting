using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody2D))]
public class Enemy : MonoBehaviour {

    public float EnemySpeed;
    public float shotDelay;
    public GameObject Bullet;
    public GameObject explosion;

    Rigidbody2D rgd2D;

    // Use this for initialization
    void Start () {
        rgd2D = GetComponent<Rigidbody2D>();
        StartCoroutine(ShotStart());
    }

    IEnumerator ShotStart()
    {

        while (true)
        {
            for (int i = 0; i < transform.childCount; ++i)
            {
                var ShotFinishedPoint = -4f;
                if (transform.position.y > ShotFinishedPoint) {
                    Transform shotPosition = transform.GetChild(i);
                    Instantiate(Bullet, shotPosition.position, shotPosition.rotation);
                }
            }

            yield return new WaitForSeconds(shotDelay);
        }

    }
    // Update is called once per frame
    void FixedUpdate()
    {
        rgd2D.velocity = transform.up * -1f * EnemySpeed;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag != StringController.Name.EnemyBullet && other.tag != StringController.Name.DestroyArea) {
            Destroy(other.gameObject);
            Instantiate(explosion, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == StringController.Name.DestroyArea) {
            Destroy(gameObject);
        }
    }

}
