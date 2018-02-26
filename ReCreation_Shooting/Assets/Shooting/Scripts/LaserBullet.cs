using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserBullet : MonoBehaviour {

    public float LaserBulletSpeed;
    public GameObject LaserTop;
    public GameObject LaserCore;

    Rigidbody2D rgd2d;
    GameObject[] LaserBulletArray = new GameObject[10];

	// Use this for initialization
	void Start () {
        rgd2d = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void LaserStart(){
        for (int i = 0; i <= 10f; ++i) {
            Vector3 LaserError = new Vector3(0f, i * 0.1f, 0f);
            Vector3 Pos = transform.position - LaserError;
        }
    }

    void AddLaserBullet() {
        //LaserBulletArray[0] = ;
        //LaserBulletArray[1] = ;
        //LaserBulletArray[2] = ;
        //LaserBulletArray[3] = ;
        //LaserBulletArray[4] = ;
        //LaserBulletArray[5] = ;
        //LaserBulletArray[6] = ;
        //LaserBulletArray[7] = ;
        //LaserBulletArray[8] = ;
        //LaserBulletArray[9] = ;
    }
}
