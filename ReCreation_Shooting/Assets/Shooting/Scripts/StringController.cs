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
        set
        {
            _xAxisName = value;
        }
    }

    string _yAxisName = "Vertical";
    public string yAxisName
    {
        get
        {
            return _yAxisName;
        }
        set
        {
            _yAxisName = value;
        }
    }

    string _playerBullet = "PlayerBullet";
    public string PlayeBullet
    {
        get        {
            return _playerBullet;
        }
        set
        {
            _playerBullet = value;
        }
    }

    string _enemyBullet = "EnemyBullet";
    public string EnemyBullet
    {
        get
        {
            return _enemyBullet;
        }
        set
        {
            _enemyBullet = value;
        }
    }

    string _destroyArea = "DestroyArea";
    public string DestroyArea
    {
        get
        {
            return _destroyArea;
        }
        set
        {
            _destroyArea = value;
        }
    }

    string _backGroundFront = "background_front";
    public string BackGroundFront
    {
        get
        {
            return _backGroundFront;
        }
        set
        {
            _backGroundFront = value;
        }
    }

    string _backGroundMiddle = "background_middle";
    public string BackGroundMiddle
    {
        get
        {
            return _backGroundMiddle;
        }
        set
        {
            _backGroundMiddle = value;
        }
    }

    string _backGroundBack = "background_back";
    public string BackGroundBack
    {
        get
        {
            return _backGroundBack;
        }
        set
        {
            _backGroundBack = value;
        }
    }

}
