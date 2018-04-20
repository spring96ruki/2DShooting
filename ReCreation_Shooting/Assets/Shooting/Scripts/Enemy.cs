using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody2D))]
public class Enemy : MonoBehaviour {

    public struct EnemyNumber
    {
        public bool Enemy1;
        public bool Enemy2;
        public bool Enemy3;
        public bool Enemy4;
        public bool Enemy5;
    }

    public float EnemySpeed;
    public float shotDelay;
    public GameObject Bullet;
    public GameObject explosion;
    public EnemyNumber enemyNumber;
    public List<bool> EnemyBool = new List<bool>();

    Rigidbody2D rgd2D;

    private void Awake()
    {
        AddListEnemyBool();
        GameManager.Instance.InitBool(EnemyBool);
    }

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

    public void AddListEnemyBool()
    {
        EnemyBool.Add(enemyNumber.Enemy1);
        EnemyBool.Add(enemyNumber.Enemy2);
        EnemyBool.Add(enemyNumber.Enemy3);
        EnemyBool.Add(enemyNumber.Enemy4);
        EnemyBool.Add(enemyNumber.Enemy5);

    }

}
