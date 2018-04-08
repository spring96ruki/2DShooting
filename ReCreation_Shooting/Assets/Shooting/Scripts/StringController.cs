using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StringController{

    static StringController instance;
    public static StringController Name
    {
        get
        {
            if (instance == null) {
                instance = new StringController();
            }
            return instance;
        }
    }

    string _xAxisName = "Horizontal";
    public string xAxisName
    {
        get
        {
            return _xAxisName;
        }
    }

    string _yAxisName = "Vertical";
    public string yAxisName
    {
        get
        {
            return _yAxisName;
        }
    }

    string _playeBullet = "PlayerBullet";
    public string PlayerBullet
    {
        get
        {
            return _playeBullet;
        }
    }

    string _enemyBullet = "EnemyBullet";
    public string EnemyBullet
    {
        get
        {
            return _enemyBullet;
        }
    }

    string _destroyArea = "DestroyArea";
    public string DestroyArea
    {
        get
        {
            return _destroyArea;
        }
    }

    string _backGroundFront = "background_front";
    public string BackGroundFront
    {
        get
        {
            return _backGroundFront;
        }
    }

    string _backGroundMiddle = "background_middle";
    public string BackGroundMiddle
    {
        get
        {
            return _backGroundMiddle;
        }
    }

    string _backGroundBack = "background_back";
    public string BackGroundBack
    {
        get
        {
            return _backGroundBack;
        }
    }

    string _enemy1 = "Enemy1";
    public string Enemy1
    {
        get
        {
            return _enemy1;
        }
    }

    string _enemy2 = "Enemy2";
    public string Enemy2
    {
        get
        {
            return _enemy2;
        }
    }

    string _enemy3 = "Enemy3";
    public string Enemy3
    {
        get
        {
            return _enemy3;
        }
    }

    string _enemy4 = "Enemy4";
    public string Enemy4
    {
        get
        {
            return _enemy4;
        }
    }

    string _enemy5 = "Enemy5";
    public string Enemy5
    {
        get
        {
            return _enemy5;
        }
    }

}
