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

    public struct EnemyNumber
    {
        public bool Enemy1;
        public bool Enemy2;
        public bool Enemy3;
        public bool Enemy4;
        public bool Enemy5;
    }

    public EnemyNumber enemyNumber;
    List<bool> EnemyBool = new List<bool>();

    private void Awake()
    {
        AddListEnemyBool();
        GameManager.Instance.InitBool(EnemyBool);
    }

    public void AddListEnemyBool()
    {
        EnemyBool.Add(enemyNumber.Enemy1);
        EnemyBool.Add(enemyNumber.Enemy2);
        EnemyBool.Add(enemyNumber.Enemy3);
        EnemyBool.Add(enemyNumber.Enemy4);
        EnemyBool.Add(enemyNumber.Enemy5);

    }

    public void JudgeEnemyBool(bool isWave, WaveState wave)
    {
        for (int i = 0; i < EnemyBool.Count; ++i)
        {
            if (EnemyBool[i] == true)
            {
                isWave = true;
                GameManager.Instance.InitBool(EnemyBool);
                WaveController.Instance.m_waveState = wave;
            }
        }
    }


    public void DisAppearObject(GameObject destroyObject) {
        Destroy(destroyObject);
        if (destroyObject.tag == StringController.Name.Enemy1)
        {
            enemyNumber.Enemy1 = true;
            WaveController.Instance.ChangeWaveBool();
        }
        if (destroyObject.tag == StringController.Name.Enemy2)
        {
            enemyNumber.Enemy2 = true;
            WaveController.Instance.ChangeWaveBool();
        }
        if (destroyObject.tag == StringController.Name.Enemy3)
        {
            enemyNumber.Enemy3 = true;
            WaveController.Instance.ChangeWaveBool();
        }
        if (destroyObject.tag == StringController.Name.Enemy4)
        {
            enemyNumber.Enemy4 = true;
            WaveController.Instance.ChangeWaveBool();
        }
        if (destroyObject.tag == StringController.Name.Enemy5)
        {
            enemyNumber.Enemy5 = true;
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
