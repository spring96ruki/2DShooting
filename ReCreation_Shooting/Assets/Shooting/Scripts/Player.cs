using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public float PlayerSpeed;
    public GameObject Bullet;
    public GameObject explosion;

    Rigidbody2D rgd2D;

    // Use this for initialization
    void Start () {
        rgd2D = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        Vector2 move = Vector2.zero;
        move.x = Input.GetAxisRaw(StringController.Name.xAxisName);
        move.y = Input.GetAxisRaw(StringController.Name.yAxisName);
        rgd2D.velocity = move * PlayerSpeed;

        if (Input.GetKeyDown(KeyCode.RightControl) || Input.GetKeyDown(KeyCode.RightControl)) {
            Instantiate(Bullet, transform.position, transform.rotation);
        } 
	}

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag != StringController.Name.PlayeBullet  && other.tag != StringController.Name.DestroyArea) {
            Destroy(other.gameObject);
            Instantiate(explosion, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }

}
