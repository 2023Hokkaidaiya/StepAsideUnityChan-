using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemEraser : MonoBehaviour
{
    //Unityちゃんのオブジェクト
    private GameObject unitychan;


    //Unityちゃんとの距離
    private float difference;

    // Use this for initialization
    void Start()
    {
        //Unityちゃんのオブジェクトを取得
        this.unitychan = GameObject.Find("unitychan");

    }

    // Update is called once per frame
    void Update()
    {
        //Unityちゃんとコインの位置（z座標）の差を求める
        this.difference = unitychan.transform.position.z - this.transform.position.z;
        //もしアイテムがユニティちゃんの後ろに行ったら(difference6以上）
        if (this.difference >= 6) 
        //このアイテムを破棄
        { 
            Destroy(this.gameObject);
        }
    }
}
