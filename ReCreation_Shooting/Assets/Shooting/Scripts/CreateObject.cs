using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateObject : MonoBehaviour {

    static CreateObject instance;
    public static CreateObject Instance
    {
        get
        {
            if (instance == null) {
                instance = new CreateObject();
            }

            return instance;
        }
    }

    public void Create(GameObject gameItem , Vector3 position, Quaternion rotation)
    {
        Instantiate(gameItem, position, rotation);
    }
}
