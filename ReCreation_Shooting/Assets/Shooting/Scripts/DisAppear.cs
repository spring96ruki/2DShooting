using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisAppear : MonoBehaviour {

    static DisAppear instance;
    public static DisAppear Instance {
        get {
            if (instance == null) {
                instance = new DisAppear();
            }
            return instance;
        }
    }

    Enemy enemyManager;
    
    public void DisAppearObject(GameObject destroyObject) {
        Destroy(destroyObject);
        if (destroyObject.tag == StringController.Name.Enemy1)
        {
            enemyManager.enemyNumber.Enemy1 = true;
            WaveController.Instance.ChangeWaveBool();
        }
        if (destroyObject.tag == StringController.Name.Enemy2)
        {
            enemyManager.enemyNumber.Enemy2 = true;
            WaveController.Instance.ChangeWaveBool();
        }
        if (destroyObject.tag == StringController.Name.Enemy3)
        {
            enemyManager.enemyNumber.Enemy3 = true;
            WaveController.Instance.ChangeWaveBool();
        }
        if (destroyObject.tag == StringController.Name.Enemy4)
        {
            enemyManager.enemyNumber.Enemy4 = true;
            WaveController.Instance.ChangeWaveBool();
        }
        if (destroyObject.tag == StringController.Name.Enemy5)
        {
            enemyManager.enemyNumber.Enemy5 = true;
            WaveController.Instance.ChangeWaveBool();
        }

        //switch (destroyObject.tag)
        //{
        //    case StringController.Name.Enemy1:
        //        enemyNumber.Enemy1 = true;
        //        break;
        //}
    }
}
