using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum WaveState
{
    unkown,
    wave1,
    wave2,
    wave3,
    wave4,
    wave5
}

public class WaveController : MonoBehaviour {

    static WaveController instance;
    public static WaveController Instance
    {
        get
        {
            if (instance == null) {
                instance = new WaveController();
            }
            return instance;
        }
    }

    public struct WaveNumber
    {
        public bool isWave1;
        public bool isWave2;
        public bool isWave3;
        public bool isWave4;
        public bool isWave5;
    }

    public WaveNumber waveNumber;

    List<bool> waveBool = new List<bool>();
    Enemy enemyManager;

    WaveState m_state;
    public WaveState m_waveState { get { return m_state; } set { m_state = value; } }

    private void Awake()
    {
        GameManager.Instance.InitBool(waveBool);
    }

    private void Start()
    {
        m_state = WaveState.wave1;
    }

    void AddListWave()
    {
        waveBool.Add(waveNumber.isWave1);
        waveBool.Add(waveNumber.isWave2);
        waveBool.Add(waveNumber.isWave3);
        waveBool.Add(waveNumber.isWave4);
        waveBool.Add(waveNumber.isWave5);
    }


    public void ChangeWaveBool()
    {
        switch (m_waveState)
        {
            case WaveState.wave1:
                GameManager.Instance.JudgeEnemyBool(waveNumber.isWave2, enemyManager.EnemyBool , WaveState.wave2);
                break;
            case WaveState.wave2:
                GameManager.Instance.JudgeEnemyBool(waveNumber.isWave3, enemyManager.EnemyBool , WaveState.wave3);
                break;
            case WaveState.wave3:
                GameManager.Instance.JudgeEnemyBool(waveNumber.isWave4, enemyManager.EnemyBool , WaveState.wave4);
                break;
            case WaveState.wave4:
                GameManager.Instance.JudgeEnemyBool(waveNumber.isWave5, enemyManager.EnemyBool , WaveState.wave5);
                break;
            case WaveState.wave5:

                break;
        }
    }
}
