using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : SingletonMono<GameManager> {

    public GameObject EnemyObject;
    public GameObject SpawnArea;

    float SpawnAreaPosX;
    float SpawnAreaPosY;
    float SpawnAreaPosZ;
    float EnemyCount = 10000f;
    float EnemyCountMax = 10000f;
    float EnemyCountBorder = 0f;

    Vector3[] SpawnAreaPosArray = new Vector3[5];
    float[] WaveCountBorder = new float[5];

    void Awake()
    {
        DisAppear.Instance.AddListEnemyBool();
        DisAppear.Instance.InitEnemyBool();
    }

    // Use this for initialization
    void Start() {
        SpawnAreaPosX = SpawnArea.transform.position.x;
        SpawnAreaPosY = SpawnArea.transform.position.y;
        SpawnAreaPosZ = SpawnArea.transform.position.z;
        AddSpawnAreaPos(SpawnAreaPosX, SpawnAreaPosY, SpawnAreaPosZ);
        AddWaveCountBorder(990f, 1000f, 2000f, 3000f);
    }

    // Update is called once per frame
    void Update() {
        --EnemyCount;
        wave1(EnemyObject);
        wave2(EnemyObject);
        wave3(EnemyObject);
        wave4(EnemyObject);
        wave5(EnemyObject);
    }

    void wave1(GameObject enemy){
        if (EnemyCount < WaveCountBorder[0] || WaveController.Instance.waveNumber.isWave1 == false) {
            for (int i = 0; i < 3; ++i){
                Instantiate(enemy, SpawnAreaPosArray[i], enemy.transform.rotation);
            }
            Debug.Log("kon");
        }

    }

    void wave2(GameObject enemy) {
        if (EnemyCount < WaveCountBorder[1] || WaveController.Instance.waveNumber.isWave2 == false) {
            for (int i = 0; i < 3; ++i) {
                Instantiate(enemy, SpawnAreaPosArray[i], enemy.transform.rotation);
            }
            Debug.Log("wan");
        }
    }

    void wave3(GameObject enemy) {
        if (EnemyCount < WaveCountBorder[2] || WaveController.Instance.waveNumber.isWave3 == false) {
            for (int i = 0; i < 3; ++i) {
                Instantiate(enemy, SpawnAreaPosArray[i], enemy.transform.rotation);
            }
            Debug.Log("nyan");
        }
    }

    void wave4(GameObject enemy) {
        if (EnemyCount < WaveCountBorder[3] || WaveController.Instance.waveNumber.isWave4== false) {
            for (int i = 0; i < 3; ++i) {
                Instantiate(enemy, SpawnAreaPosArray[i], enemy.transform.rotation);
            }
            Debug.Log("ton");
        }
    }

    void wave5(GameObject enemy)  {
        if (EnemyCount < WaveCountBorder[4] || WaveController.Instance.waveNumber.isWave5 == false) {
            for (int i = 0; i < 3; ++i) {
                Instantiate(enemy, SpawnAreaPosArray[i], enemy.transform.rotation);
            }
            Debug.Log("toy");
        }
    }


    void AddSpawnAreaPos(float x, float y, float z) {
        Vector3 SpawnAreaPosCenter = SpawnArea.transform.position;
        Vector3 SpawnAreaPosRight = new Vector3(x + 0.5f, y + 0.5f, z);
        Vector3 SpawnAreaPosLight = new Vector3(x - 0.5f, y + 0.5f, z);
        Vector3 SpawnAreaPosRightEnd = new Vector3(x + 1f, y + 1f, z);
        Vector3 SpawnAreaPosLightEnd = new Vector3(x - 1f, y - 1f, z);
        SpawnAreaPosArray[0] = SpawnAreaPosCenter;
        SpawnAreaPosArray[1] = SpawnAreaPosRight;
        SpawnAreaPosArray[2] = SpawnAreaPosLight;
        SpawnAreaPosArray[3] = SpawnAreaPosRightEnd;
        SpawnAreaPosArray[4] = SpawnAreaPosLightEnd;
    }

    void AddWaveCountBorder(float wave1Next, float wave2Next, float wave3Next, float wave4Next)
    {
        float wave1Border = 9990f;
        float wave2Border = wave1Border - wave1Next;
        float wave3Border = wave2Border - wave2Next;
        float wave4Border = wave3Border - wave3Next;
        float wave5Border = wave4Border - wave4Next;
        WaveCountBorder[0] = wave1Border;
        WaveCountBorder[1] = wave2Border;
        WaveCountBorder[2] = wave3Border;
        WaveCountBorder[3] = wave4Border;
        WaveCountBorder[4] = wave5Border;
    }

}
