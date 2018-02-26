using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGrounds : MonoBehaviour {

    public float ScrollSpeedBack;
    public float ScrollSpeedFront;
    public float ScrollSpeedMiddle;

    float sizeError = 0.1f;
    float SpriteCount = 2f;
    List<GameObject> BackGroundSprites = new List<GameObject>();
    Vector3 SpriteSize;


	void Start () {
        AddBackGroundSprite();
        SpriteSize = BackGroundSprites[0].GetComponent<SpriteRenderer>().bounds.size;
    }

    void AddBackGroundSprite()
    {
        GameObject childFront = transform.FindChild(StringController.Name.BackGroundFront).gameObject;
        GameObject childMiddle = transform.FindChild(StringController.Name.BackGroundMiddle).gameObject;
        GameObject childBack = transform.FindChild(StringController.Name.BackGroundBack).gameObject;
        BackGroundSprites.Add(childFront);
        BackGroundSprites.Add(childMiddle);
        BackGroundSprites.Add(childBack);
    }


    void Update()
    {
        BackGroundSprites[0].transform.position += Vector3.down * ScrollSpeedFront * Time.deltaTime;
        BackGroundSprites[1].transform.position += Vector3.down * ScrollSpeedMiddle * Time.deltaTime;
        BackGroundSprites[2].transform.position += Vector3.down * ScrollSpeedBack * Time.deltaTime;

        float SpriteY_front = (BackGroundSprites[0].transform.position + SpriteSize / 2).y;
        float SpriteY_middle = (BackGroundSprites[1].transform.position + SpriteSize / 2).y;
        float SpriteY_back = (BackGroundSprites[2].transform.position + SpriteSize / 2).y;


        if (SpriteY_front < ScreenManager.Instance.screenRect.y)
        {
            float height = BackGroundSprites[0].GetComponent<SpriteRenderer>().bounds.size.y - sizeError;
            BackGroundSprites[0].transform.position += Vector3.up * height * SpriteCount;
        }
        if (SpriteY_middle < ScreenManager.Instance.screenRect.y)
        {
            float height = BackGroundSprites[1].GetComponent<SpriteRenderer>().bounds.size.y - sizeError;
            BackGroundSprites[1].transform.position += Vector3.up * height * SpriteCount;
        }
        if (SpriteY_back < ScreenManager.Instance.screenRect.y)
        {
            float height = BackGroundSprites[2].GetComponent<SpriteRenderer>().bounds.size.y - sizeError;
            BackGroundSprites[2].transform.position += Vector3.up * height * SpriteCount;
        }
    }


}
